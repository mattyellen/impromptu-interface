﻿// 
//  Copyright 2011  Ekon Benefits
// 
//    Licensed under the Apache License, Version 2.0 (the "License");
//    you may not use this file except in compliance with the License.
//    You may obtain a copy of the License at
// 
//        http://www.apache.org/licenses/LICENSE-2.0
// 
//    Unless required by applicable law or agreed to in writing, software
//    distributed under the License is distributed on an "AS IS" BASIS,
//    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//    See the License for the specific language governing permissions and
//    limitations under the License.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.CSharp.RuntimeBinder;

namespace ImpromptuInterface.Dynamic
{
    /// <summary>
    /// Type of Invocation
    /// </summary>
    [Serializable]
    public enum InvocationKind
    {
        /// <summary>
        /// NotSet
        /// </summary>
        NotSet=0,
        /// <summary>
        /// Convert, Implicit or Explict depending on arguments
        /// </summary>
        Convert,
        /// <summary>
        /// Get Property
        /// </summary>
        Get,
        /// <summary>
        /// Set Property
        /// </summary>
        Set,
        /// <summary>
        /// Get Indexer
        /// </summary>
        GetIndex,
        /// <summary>
        /// Set Indexer
        /// </summary>
        SetIndex,
        /// <summary>
        /// Invoke Method the has return value
        /// </summary>
        InvokeMember,
        /// <summary>
        /// Invoke Method that returns void
        /// </summary>
        InvokeMemberAction,
        /// <summary>
        /// Invoke Method that could return a value or void
        /// </summary>
        InvokeMemberUnknown,
        /// <summary>
        /// Invoke Constructor
        /// </summary>
        Constructor,
        /// <summary>
        /// Invoke +=
        /// </summary>
        AddAssign,
        /// <summary>
        /// Invoke -=
        /// </summary>
        SubtractAssign,
        /// <summary>
        /// Invoke Event Property Test
        /// </summary>
        IsEvent,
    }

    /// <summary>
    /// Storable representation of an invocation without the target
    /// </summary>
    [Serializable]
    public class Invocation
    {

        /// <summary>
        /// Defacto Binder Name for Explicit Convert Op
        /// </summary>
        public static readonly string ExplicitConvertBinderName = "(Explicit)";

        /// <summary>
        /// Defacto Binder Name for Implicit Convert Op
        /// </summary>
        public static readonly string ImplicitConvertBinderName = "(Implicit)";

        /// <summary>
        /// Defacto Binder Name for Indexer
        /// </summary>
        public static readonly string IndexBinderName = "Item";


        /// <summary>
        /// Defacto Binder Name for Construvter
        /// </summary>
        public static readonly string ConstructorBinderName = "new()";

        /// <summary>
        /// Gets or sets the kind.
        /// </summary>
        /// <value>The kind.</value>
        public InvocationKind Kind { get; protected set; }
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        public String_OR_InvokeMemberName Name { get; protected set; }
        /// <summary>
        /// Gets or sets the args.
        /// </summary>
        /// <value>The args.</value>
        public object[] Args { get; protected set; }


        /// <summary>
        /// Creates the invocation.
        /// </summary>
        /// <param name="kind">The kind.</param>
        /// <param name="name">The name.</param>
        /// <param name="args">The args.</param>
        /// <returns></returns>
        public static Invocation Create(InvocationKind kind, String_OR_InvokeMemberName name, params object[] args)
        {
            return new Invocation(kind,name,args);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Invocation"/> class.
        /// </summary>
        /// <param name="kind">The kind.</param>
        /// <param name="name">The name.</param>
        /// <param name="args">The args.</param>
        public Invocation(InvocationKind kind, String_OR_InvokeMemberName name, params object[] args)
        {
            Kind = kind;
            Name = name;
            Args = args;
        }


        /// <summary>
        /// Invokes the invocation on specified target with specific args.
        /// </summary>
        /// <param name="target">The target.</param>
        /// <param name="args">The args.</param>
        /// <returns></returns>
        public object InvokeWithArgs(object target, params object[] args)
        {
            switch (Kind)
            {
                case InvocationKind.Constructor:
                    return Impromptu.InvokeConstuctor((Type)target, args);
                case InvocationKind.Convert:
                    bool tExplict = false;
                    if (Args.Length == 2)
                        tExplict = (bool)args[1];
                    return Impromptu.InvokeConvert(target, (Type)args[0], tExplict);
                case InvocationKind.Get:
                    return Impromptu.InvokeGet(target, Name.Name);
                case InvocationKind.Set:
                    Impromptu.InvokeSet(target, Name.Name, args.FirstOrDefault());
                    return null;
                case InvocationKind.GetIndex:
                    return Impromptu.InvokeGetIndex(target, args);
                case InvocationKind.SetIndex:
                    Impromptu.InvokeSetIndex(target, args);
                    return null;
                case InvocationKind.InvokeMember:
                    return Impromptu.InvokeMember(target, Name, args);
                case InvocationKind.InvokeMemberAction:
                    Impromptu.InvokeMemberAction(target, Name, args);
                    return null;
                case InvocationKind.InvokeMemberUnknown:
                    {
                        try
                        {
                            return Impromptu.InvokeMember(target, Name, args);
                        }
                        catch (RuntimeBinderException)
                        {

                            Impromptu.InvokeMemberAction(target, Name, args);
                            return null;
                        }
                    }
                case InvocationKind.AddAssign:
                    Impromptu.InvokeAddAssign(target, Name.Name, args.FirstOrDefault());
                    return null;
                case InvocationKind.SubtractAssign:
                    Impromptu.InvokeSubtractAssign(target, Name.Name, args.FirstOrDefault());
                    return null;
                case InvocationKind.IsEvent:
                    return Impromptu.InvokeIsEvent(target, Name.Name);
                default:
                    throw new InvalidOperationException("Unknown Invocation Kind: " + Kind);
            }

        }


        /// <summary>
        /// Invokes the invocation on specified target.
        /// </summary>
        /// <param name="target">The target.</param>
        /// <returns></returns>
        public object Invoke(object target)
        {
            return InvokeWithArgs(target, Args);
        }
    }
}
