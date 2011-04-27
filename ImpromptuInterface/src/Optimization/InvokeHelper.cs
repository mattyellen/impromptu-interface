﻿
// 
//  Copyright 2011 Ekon Benefits
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
using System.Runtime.CompilerServices;
using ImpromptuInterface.Build;
using Microsoft.CSharp.RuntimeBinder;
using ImpromptuInterface.Dynamic;
using System.Reflection;

namespace ImpromptuInterface.Optimization
{
  

    internal static partial class InvokeHelper
    {


        internal static readonly Type[] FuncKinds;
        internal static readonly Type[] ActionKinds;

        static InvokeHelper()
        {
            FuncKinds = new []
                            {
								typeof(Func<>), //0
								typeof(Func<,>), //1
								typeof(Func<,,>), //2
								typeof(Func<,,,>), //3
								typeof(Func<,,,,>), //4
								typeof(Func<,,,,,>), //5
								typeof(Func<,,,,,,>), //6
								typeof(Func<,,,,,,,>), //7
								typeof(Func<,,,,,,,,>), //8
								typeof(Func<,,,,,,,,,>), //9
								typeof(Func<,,,,,,,,,,>), //10
								typeof(Func<,,,,,,,,,,,>), //11
								typeof(Func<,,,,,,,,,,,,>), //12
								typeof(Func<,,,,,,,,,,,,,>), //13
								typeof(Func<,,,,,,,,,,,,,,>), //14
								typeof(Func<,,,,,,,,,,,,,,,>), //15
								typeof(Func<,,,,,,,,,,,,,,,,>), //16
                            };

            ActionKinds = new []
                            {
                                typeof(Action), //0
								typeof(Action<>), //1
								typeof(Action<,>), //2
								typeof(Action<,,>), //3
								typeof(Action<,,,>), //4
								typeof(Action<,,,,>), //5
								typeof(Action<,,,,,>), //6
								typeof(Action<,,,,,,>), //7
								typeof(Action<,,,,,,,>), //8
								typeof(Action<,,,,,,,,>), //9
								typeof(Action<,,,,,,,,,>), //10
								typeof(Action<,,,,,,,,,,>), //11
								typeof(Action<,,,,,,,,,,,>), //12
								typeof(Action<,,,,,,,,,,,,>), //13
								typeof(Action<,,,,,,,,,,,,,>), //14
								typeof(Action<,,,,,,,,,,,,,,>), //15
								typeof(Action<,,,,,,,,,,,,,,,>), //16
                            };
        }

        #region InvokeMemberAction Optimizations


        internal static void InvokeMemberAction(ref CallSite callsite,
													CallSiteBinder binder,
                                                    String_OR_InvokeMemberName name,
													bool staticContext,
                                                    Type context, 
                                                    string[] argNames,
                                                    object target,
                                                    params object [] args)
        {

            var tSwitch = args.Length;
            switch (tSwitch)
            {
                case 0:
                    {
						var tCallSite = (CallSite<Action<CallSite,  object>>)callsite;
						if(tCallSite == null){
							tCallSite = Impromptu.CreateCallSite<Action<CallSite,  object>>(binder, name, context, argNames, staticContext);
						    callsite=tCallSite;
						}
                        tCallSite.Target(tCallSite, target);
                        break;
                    }
                case 1:
                    {
						var tCallSite = (CallSite<Action<CallSite,  object, object>>)callsite;
						if(tCallSite == null){
							tCallSite = Impromptu.CreateCallSite<Action<CallSite,  object, object>>(binder, name, context, argNames, staticContext);
						    callsite=tCallSite;
						}
                        tCallSite.Target(tCallSite, target, args[0]);
                        break;
                    }
                case 2:
                    {
						var tCallSite = (CallSite<Action<CallSite,  object, object, object>>)callsite;
						if(tCallSite == null){
							tCallSite = Impromptu.CreateCallSite<Action<CallSite,  object, object, object>>(binder, name, context, argNames, staticContext);
						    callsite=tCallSite;
						}
                        tCallSite.Target(tCallSite, target, args[0], args[1]);
                        break;
                    }
                case 3:
                    {
						var tCallSite = (CallSite<Action<CallSite,  object, object, object, object>>)callsite;
						if(tCallSite == null){
							tCallSite = Impromptu.CreateCallSite<Action<CallSite,  object, object, object, object>>(binder, name, context, argNames, staticContext);
						    callsite=tCallSite;
						}
                        tCallSite.Target(tCallSite, target, args[0], args[1], args[2]);
                        break;
                    }
                case 4:
                    {
						var tCallSite = (CallSite<Action<CallSite,  object, object, object, object, object>>)callsite;
						if(tCallSite == null){
							tCallSite = Impromptu.CreateCallSite<Action<CallSite,  object, object, object, object, object>>(binder, name, context, argNames, staticContext);
						    callsite=tCallSite;
						}
                        tCallSite.Target(tCallSite, target, args[0], args[1], args[2], args[3]);
                        break;
                    }
                case 5:
                    {
						var tCallSite = (CallSite<Action<CallSite,  object, object, object, object, object, object>>)callsite;
						if(tCallSite == null){
							tCallSite = Impromptu.CreateCallSite<Action<CallSite,  object, object, object, object, object, object>>(binder, name, context, argNames, staticContext);
						    callsite=tCallSite;
						}
                        tCallSite.Target(tCallSite, target, args[0], args[1], args[2], args[3], args[4]);
                        break;
                    }
                case 6:
                    {
						var tCallSite = (CallSite<Action<CallSite,  object, object, object, object, object, object, object>>)callsite;
						if(tCallSite == null){
							tCallSite = Impromptu.CreateCallSite<Action<CallSite,  object, object, object, object, object, object, object>>(binder, name, context, argNames, staticContext);
						    callsite=tCallSite;
						}
                        tCallSite.Target(tCallSite, target, args[0], args[1], args[2], args[3], args[4], args[5]);
                        break;
                    }
                case 7:
                    {
						var tCallSite = (CallSite<Action<CallSite,  object, object, object, object, object, object, object, object>>)callsite;
						if(tCallSite == null){
							tCallSite = Impromptu.CreateCallSite<Action<CallSite,  object, object, object, object, object, object, object, object>>(binder, name, context, argNames, staticContext);
						    callsite=tCallSite;
						}
                        tCallSite.Target(tCallSite, target, args[0], args[1], args[2], args[3], args[4], args[5], args[6]);
                        break;
                    }
                case 8:
                    {
						var tCallSite = (CallSite<Action<CallSite,  object, object, object, object, object, object, object, object, object>>)callsite;
						if(tCallSite == null){
							tCallSite = Impromptu.CreateCallSite<Action<CallSite,  object, object, object, object, object, object, object, object, object>>(binder, name, context, argNames, staticContext);
						    callsite=tCallSite;
						}
                        tCallSite.Target(tCallSite, target, args[0], args[1], args[2], args[3], args[4], args[5], args[6], args[7]);
                        break;
                    }
                case 9:
                    {
						var tCallSite = (CallSite<Action<CallSite,  object, object, object, object, object, object, object, object, object, object>>)callsite;
						if(tCallSite == null){
							tCallSite = Impromptu.CreateCallSite<Action<CallSite,  object, object, object, object, object, object, object, object, object, object>>(binder, name, context, argNames, staticContext);
						    callsite=tCallSite;
						}
                        tCallSite.Target(tCallSite, target, args[0], args[1], args[2], args[3], args[4], args[5], args[6], args[7], args[8]);
                        break;
                    }
                case 10:
                    {
						var tCallSite = (CallSite<Action<CallSite,  object, object, object, object, object, object, object, object, object, object, object>>)callsite;
						if(tCallSite == null){
							tCallSite = Impromptu.CreateCallSite<Action<CallSite,  object, object, object, object, object, object, object, object, object, object, object>>(binder, name, context, argNames, staticContext);
						    callsite=tCallSite;
						}
                        tCallSite.Target(tCallSite, target, args[0], args[1], args[2], args[3], args[4], args[5], args[6], args[7], args[8], args[9]);
                        break;
                    }
                case 11:
                    {
						var tCallSite = (CallSite<Action<CallSite,  object, object, object, object, object, object, object, object, object, object, object, object>>)callsite;
						if(tCallSite == null){
							tCallSite = Impromptu.CreateCallSite<Action<CallSite,  object, object, object, object, object, object, object, object, object, object, object, object>>(binder, name, context, argNames, staticContext);
						    callsite=tCallSite;
						}
                        tCallSite.Target(tCallSite, target, args[0], args[1], args[2], args[3], args[4], args[5], args[6], args[7], args[8], args[9], args[10]);
                        break;
                    }
                case 12:
                    {
						var tCallSite = (CallSite<Action<CallSite,  object, object, object, object, object, object, object, object, object, object, object, object, object>>)callsite;
						if(tCallSite == null){
							tCallSite = Impromptu.CreateCallSite<Action<CallSite,  object, object, object, object, object, object, object, object, object, object, object, object, object>>(binder, name, context, argNames, staticContext);
						    callsite=tCallSite;
						}
                        tCallSite.Target(tCallSite, target, args[0], args[1], args[2], args[3], args[4], args[5], args[6], args[7], args[8], args[9], args[10], args[11]);
                        break;
                    }
                case 13:
                    {
						var tCallSite = (CallSite<Action<CallSite,  object, object, object, object, object, object, object, object, object, object, object, object, object, object>>)callsite;
						if(tCallSite == null){
							tCallSite = Impromptu.CreateCallSite<Action<CallSite,  object, object, object, object, object, object, object, object, object, object, object, object, object, object>>(binder, name, context, argNames, staticContext);
						    callsite=tCallSite;
						}
                        tCallSite.Target(tCallSite, target, args[0], args[1], args[2], args[3], args[4], args[5], args[6], args[7], args[8], args[9], args[10], args[11], args[12]);
                        break;
                    }
                case 14:
                    {
						var tCallSite = (CallSite<Action<CallSite,  object, object, object, object, object, object, object, object, object, object, object, object, object, object, object>>)callsite;
						if(tCallSite == null){
							tCallSite = Impromptu.CreateCallSite<Action<CallSite,  object, object, object, object, object, object, object, object, object, object, object, object, object, object, object>>(binder, name, context, argNames, staticContext);
						    callsite=tCallSite;
						}
                        tCallSite.Target(tCallSite, target, args[0], args[1], args[2], args[3], args[4], args[5], args[6], args[7], args[8], args[9], args[10], args[11], args[12], args[13]);
                        break;
                    }
                default:
                    var tArgTypes = Enumerable.Repeat(typeof(object), tSwitch);
                    var tDelagateType = BuildProxy.GenerateCallSiteFuncType(tArgTypes, typeof(void));
                    Impromptu.Invoke(Impromptu.CreateCallSite(tDelagateType, binder, name, context, argNames), target, args);
                    break;

            }
        }

        #endregion

       

        #region InvokeMember Optimizations


        internal static TReturn InvokeMemberTargetType<TTarget,TReturn>(
										ref CallSite callsite,
										CallSiteBinder binder,
                                       String_OR_InvokeMemberName name,
									 bool staticContext,
                                     Type context,
                                     string[] argNames,
                                     TTarget target, params object [] args)
        {

        

            var tSwitch = args.Length;

            switch (tSwitch)
            {
                case 0:
                    {
					    var tCallSite = (CallSite<Func<CallSite, TTarget, TReturn>>)callsite;
					    if(tCallSite==null){
							 tCallSite = Impromptu.CreateCallSite<Func<CallSite, TTarget, TReturn>>(binder, name, context, argNames, staticContext);
							 callsite =tCallSite;
						}
                        return tCallSite.Target(tCallSite, target);
                    }
                case 1:
                    {
					    var tCallSite = (CallSite<Func<CallSite, TTarget,  object,TReturn>>)callsite;
					    if(tCallSite==null){
							 tCallSite = Impromptu.CreateCallSite<Func<CallSite, TTarget,  object,TReturn>>(binder, name, context, argNames, staticContext);
							 callsite =tCallSite;
						}
                        return tCallSite.Target(tCallSite, target, args[0]);
                    }
                case 2:
                    {
					    var tCallSite = (CallSite<Func<CallSite, TTarget,  object, object,TReturn>>)callsite;
					    if(tCallSite==null){
							 tCallSite = Impromptu.CreateCallSite<Func<CallSite, TTarget,  object, object,TReturn>>(binder, name, context, argNames, staticContext);
							 callsite =tCallSite;
						}
                        return tCallSite.Target(tCallSite, target, args[0], args[1]);
                    }
                case 3:
                    {
					    var tCallSite = (CallSite<Func<CallSite, TTarget,  object, object, object,TReturn>>)callsite;
					    if(tCallSite==null){
							 tCallSite = Impromptu.CreateCallSite<Func<CallSite, TTarget,  object, object, object,TReturn>>(binder, name, context, argNames, staticContext);
							 callsite =tCallSite;
						}
                        return tCallSite.Target(tCallSite, target, args[0], args[1], args[2]);
                    }
                case 4:
                    {
					    var tCallSite = (CallSite<Func<CallSite, TTarget,  object, object, object, object,TReturn>>)callsite;
					    if(tCallSite==null){
							 tCallSite = Impromptu.CreateCallSite<Func<CallSite, TTarget,  object, object, object, object,TReturn>>(binder, name, context, argNames, staticContext);
							 callsite =tCallSite;
						}
                        return tCallSite.Target(tCallSite, target, args[0], args[1], args[2], args[3]);
                    }
                case 5:
                    {
					    var tCallSite = (CallSite<Func<CallSite, TTarget,  object, object, object, object, object,TReturn>>)callsite;
					    if(tCallSite==null){
							 tCallSite = Impromptu.CreateCallSite<Func<CallSite, TTarget,  object, object, object, object, object,TReturn>>(binder, name, context, argNames, staticContext);
							 callsite =tCallSite;
						}
                        return tCallSite.Target(tCallSite, target, args[0], args[1], args[2], args[3], args[4]);
                    }
                case 6:
                    {
					    var tCallSite = (CallSite<Func<CallSite, TTarget,  object, object, object, object, object, object,TReturn>>)callsite;
					    if(tCallSite==null){
							 tCallSite = Impromptu.CreateCallSite<Func<CallSite, TTarget,  object, object, object, object, object, object,TReturn>>(binder, name, context, argNames, staticContext);
							 callsite =tCallSite;
						}
                        return tCallSite.Target(tCallSite, target, args[0], args[1], args[2], args[3], args[4], args[5]);
                    }
                case 7:
                    {
					    var tCallSite = (CallSite<Func<CallSite, TTarget,  object, object, object, object, object, object, object,TReturn>>)callsite;
					    if(tCallSite==null){
							 tCallSite = Impromptu.CreateCallSite<Func<CallSite, TTarget,  object, object, object, object, object, object, object,TReturn>>(binder, name, context, argNames, staticContext);
							 callsite =tCallSite;
						}
                        return tCallSite.Target(tCallSite, target, args[0], args[1], args[2], args[3], args[4], args[5], args[6]);
                    }
                case 8:
                    {
					    var tCallSite = (CallSite<Func<CallSite, TTarget,  object, object, object, object, object, object, object, object,TReturn>>)callsite;
					    if(tCallSite==null){
							 tCallSite = Impromptu.CreateCallSite<Func<CallSite, TTarget,  object, object, object, object, object, object, object, object,TReturn>>(binder, name, context, argNames, staticContext);
							 callsite =tCallSite;
						}
                        return tCallSite.Target(tCallSite, target, args[0], args[1], args[2], args[3], args[4], args[5], args[6], args[7]);
                    }
                case 9:
                    {
					    var tCallSite = (CallSite<Func<CallSite, TTarget,  object, object, object, object, object, object, object, object, object,TReturn>>)callsite;
					    if(tCallSite==null){
							 tCallSite = Impromptu.CreateCallSite<Func<CallSite, TTarget,  object, object, object, object, object, object, object, object, object,TReturn>>(binder, name, context, argNames, staticContext);
							 callsite =tCallSite;
						}
                        return tCallSite.Target(tCallSite, target, args[0], args[1], args[2], args[3], args[4], args[5], args[6], args[7], args[8]);
                    }
                case 10:
                    {
					    var tCallSite = (CallSite<Func<CallSite, TTarget,  object, object, object, object, object, object, object, object, object, object,TReturn>>)callsite;
					    if(tCallSite==null){
							 tCallSite = Impromptu.CreateCallSite<Func<CallSite, TTarget,  object, object, object, object, object, object, object, object, object, object,TReturn>>(binder, name, context, argNames, staticContext);
							 callsite =tCallSite;
						}
                        return tCallSite.Target(tCallSite, target, args[0], args[1], args[2], args[3], args[4], args[5], args[6], args[7], args[8], args[9]);
                    }
                case 11:
                    {
					    var tCallSite = (CallSite<Func<CallSite, TTarget,  object, object, object, object, object, object, object, object, object, object, object,TReturn>>)callsite;
					    if(tCallSite==null){
							 tCallSite = Impromptu.CreateCallSite<Func<CallSite, TTarget,  object, object, object, object, object, object, object, object, object, object, object,TReturn>>(binder, name, context, argNames, staticContext);
							 callsite =tCallSite;
						}
                        return tCallSite.Target(tCallSite, target, args[0], args[1], args[2], args[3], args[4], args[5], args[6], args[7], args[8], args[9], args[10]);
                    }
                case 12:
                    {
					    var tCallSite = (CallSite<Func<CallSite, TTarget,  object, object, object, object, object, object, object, object, object, object, object, object,TReturn>>)callsite;
					    if(tCallSite==null){
							 tCallSite = Impromptu.CreateCallSite<Func<CallSite, TTarget,  object, object, object, object, object, object, object, object, object, object, object, object,TReturn>>(binder, name, context, argNames, staticContext);
							 callsite =tCallSite;
						}
                        return tCallSite.Target(tCallSite, target, args[0], args[1], args[2], args[3], args[4], args[5], args[6], args[7], args[8], args[9], args[10], args[11]);
                    }
                case 13:
                    {
					    var tCallSite = (CallSite<Func<CallSite, TTarget,  object, object, object, object, object, object, object, object, object, object, object, object, object,TReturn>>)callsite;
					    if(tCallSite==null){
							 tCallSite = Impromptu.CreateCallSite<Func<CallSite, TTarget,  object, object, object, object, object, object, object, object, object, object, object, object, object,TReturn>>(binder, name, context, argNames, staticContext);
							 callsite =tCallSite;
						}
                        return tCallSite.Target(tCallSite, target, args[0], args[1], args[2], args[3], args[4], args[5], args[6], args[7], args[8], args[9], args[10], args[11], args[12]);
                    }
                case 14:
                    {
					    var tCallSite = (CallSite<Func<CallSite, TTarget,  object, object, object, object, object, object, object, object, object, object, object, object, object, object,TReturn>>)callsite;
					    if(tCallSite==null){
							 tCallSite = Impromptu.CreateCallSite<Func<CallSite, TTarget,  object, object, object, object, object, object, object, object, object, object, object, object, object, object,TReturn>>(binder, name, context, argNames, staticContext);
							 callsite =tCallSite;
						}
                        return tCallSite.Target(tCallSite, target, args[0], args[1], args[2], args[3], args[4], args[5], args[6], args[7], args[8], args[9], args[10], args[11], args[12], args[13]);
                    }
                default:
                    var tArgTypes = Enumerable.Repeat(typeof(object), tSwitch);
                    var tDelagateType = BuildProxy.GenerateCallSiteFuncType(tArgTypes, typeof(TTarget));
                    return Impromptu.Invoke(Impromptu.CreateCallSite(tDelagateType, binder, name, context, argNames), target, args);

            }
        }

     

        #endregion


        internal static object FastDynamicInvokeReturn(Delegate del, dynamic [] args)
        {
            dynamic tDel =del;
            switch(args.Length){
                default:
                    return del.DynamicInvoke(args);
#region Optimization
				case 1:
                    return tDel(args[0]);
				case 2:
                    return tDel(args[0],args[1]);
				case 3:
                    return tDel(args[0],args[1],args[2]);
				case 4:
                    return tDel(args[0],args[1],args[2],args[3]);
				case 5:
                    return tDel(args[0],args[1],args[2],args[3],args[4]);
				case 6:
                    return tDel(args[0],args[1],args[2],args[3],args[4],args[5]);
				case 7:
                    return tDel(args[0],args[1],args[2],args[3],args[4],args[5],args[6]);
				case 8:
                    return tDel(args[0],args[1],args[2],args[3],args[4],args[5],args[6],args[7]);
				case 9:
                    return tDel(args[0],args[1],args[2],args[3],args[4],args[5],args[6],args[7],args[8]);
				case 10:
                    return tDel(args[0],args[1],args[2],args[3],args[4],args[5],args[6],args[7],args[8],args[9]);
				case 11:
                    return tDel(args[0],args[1],args[2],args[3],args[4],args[5],args[6],args[7],args[8],args[9],args[10]);
				case 12:
                    return tDel(args[0],args[1],args[2],args[3],args[4],args[5],args[6],args[7],args[8],args[9],args[10],args[11]);
				case 13:
                    return tDel(args[0],args[1],args[2],args[3],args[4],args[5],args[6],args[7],args[8],args[9],args[10],args[11],args[12]);
				case 14:
                    return tDel(args[0],args[1],args[2],args[3],args[4],args[5],args[6],args[7],args[8],args[9],args[10],args[11],args[12],args[13]);
				case 15:
                    return tDel(args[0],args[1],args[2],args[3],args[4],args[5],args[6],args[7],args[8],args[9],args[10],args[11],args[12],args[13],args[14]);
				case 16:
                    return tDel(args[0],args[1],args[2],args[3],args[4],args[5],args[6],args[7],args[8],args[9],args[10],args[11],args[12],args[13],args[14],args[15]);
#endregion
            }
        }

        internal static void FastDynamicInvokeAction(Delegate del, params dynamic [] args)
        {
            dynamic tDel =del;
            switch(args.Length){
                default:
                    del.DynamicInvoke(args);
                    return;
#region Optimization
				case 1:
                    tDel(args[0]);
                    return;
				case 2:
                    tDel(args[0],args[1]);
                    return;
				case 3:
                    tDel(args[0],args[1],args[2]);
                    return;
				case 4:
                    tDel(args[0],args[1],args[2],args[3]);
                    return;
				case 5:
                    tDel(args[0],args[1],args[2],args[3],args[4]);
                    return;
				case 6:
                    tDel(args[0],args[1],args[2],args[3],args[4],args[5]);
                    return;
				case 7:
                    tDel(args[0],args[1],args[2],args[3],args[4],args[5],args[6]);
                    return;
				case 8:
                    tDel(args[0],args[1],args[2],args[3],args[4],args[5],args[6],args[7]);
                    return;
				case 9:
                    tDel(args[0],args[1],args[2],args[3],args[4],args[5],args[6],args[7],args[8]);
                    return;
				case 10:
                    tDel(args[0],args[1],args[2],args[3],args[4],args[5],args[6],args[7],args[8],args[9]);
                    return;
				case 11:
                    tDel(args[0],args[1],args[2],args[3],args[4],args[5],args[6],args[7],args[8],args[9],args[10]);
                    return;
				case 12:
                    tDel(args[0],args[1],args[2],args[3],args[4],args[5],args[6],args[7],args[8],args[9],args[10],args[11]);
                    return;
				case 13:
                    tDel(args[0],args[1],args[2],args[3],args[4],args[5],args[6],args[7],args[8],args[9],args[10],args[11],args[12]);
                    return;
				case 14:
                    tDel(args[0],args[1],args[2],args[3],args[4],args[5],args[6],args[7],args[8],args[9],args[10],args[11],args[12],args[13]);
                    return;
				case 15:
                    tDel(args[0],args[1],args[2],args[3],args[4],args[5],args[6],args[7],args[8],args[9],args[10],args[11],args[12],args[13],args[14]);
                    return;
				case 16:
                    tDel(args[0],args[1],args[2],args[3],args[4],args[5],args[6],args[7],args[8],args[9],args[10],args[11],args[12],args[13],args[14],args[15]);
                    return;
#endregion
            }
        }
    }
}