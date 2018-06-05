//Generated by Agni.Clients.Tools.AgniGluecCompiler

/* Auto generated by Glue Client Compiler tool (gluec)
on 22.08.2017 19:41:45 at CRAZYROGUE by mad
Do not modify this file by hand if you plan to regenerate this file again by the tool as manual changes will be lost
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

using NFX.Glue;
using NFX.Glue.Protocol;


namespace Agni.Social.Graph
{
// This implementation needs @Agni.@Social.@Graph.@IGraphEventSystemClient, so
// it can be used with ServiceClientHub class

  ///<summary>
  /// Client for glued contract Agni.Social.Graph.IGraphEventSystem server.
  /// Each contract method has synchronous and asynchronous versions, the later denoted by 'Async_' prefix.
  /// May inject client-level inspectors here like so:
  ///   client.MsgInspectors.Register( new YOUR_CLIENT_INSPECTOR_TYPE());
  ///</summary>
  public class GraphEventSystemClient : ClientEndPoint, @Agni.@Social.@Graph.@IGraphEventSystemClient
  {

  #region Static Members

     private static TypeSpec s_ts_CONTRACT;
     private static MethodSpec @s_ms_EmitEvent_0;
     private static MethodSpec @s_ms_Subscribe_1;
     private static MethodSpec @s_ms_Unsubscribe_2;
     private static MethodSpec @s_ms_EstimateSubscriberCount_3;
     private static MethodSpec @s_ms_GetSubscribers_4;

     //static .ctor
     static GraphEventSystemClient()
     {
         var t = typeof(@Agni.@Social.@Graph.@IGraphEventSystem);
         s_ts_CONTRACT = new TypeSpec(t);
         @s_ms_EmitEvent_0 = new MethodSpec(t.GetMethod("EmitEvent", new Type[]{ typeof(@Agni.@Social.@Graph.@Event) }));
         @s_ms_Subscribe_1 = new MethodSpec(t.GetMethod("Subscribe", new Type[]{ typeof(@NFX.@DataAccess.@Distributed.@GDID), typeof(@NFX.@DataAccess.@Distributed.@GDID), typeof(@System.@Byte[]) }));
         @s_ms_Unsubscribe_2 = new MethodSpec(t.GetMethod("Unsubscribe", new Type[]{ typeof(@NFX.@DataAccess.@Distributed.@GDID), typeof(@NFX.@DataAccess.@Distributed.@GDID) }));
         @s_ms_EstimateSubscriberCount_3 = new MethodSpec(t.GetMethod("EstimateSubscriberCount", new Type[]{ typeof(@NFX.@DataAccess.@Distributed.@GDID) }));
         @s_ms_GetSubscribers_4 = new MethodSpec(t.GetMethod("GetSubscribers", new Type[]{ typeof(@NFX.@DataAccess.@Distributed.@GDID), typeof(@System.@Int64), typeof(@System.@Int32) }));
     }
  #endregion

  #region .ctor
     public GraphEventSystemClient(string node, Binding binding = null) : base(node, binding) { ctor(); }
     public GraphEventSystemClient(Node node, Binding binding = null) : base(node, binding) { ctor(); }
     public GraphEventSystemClient(IGlue glue, string node, Binding binding = null) : base(glue, node, binding) { ctor(); }
     public GraphEventSystemClient(IGlue glue, Node node, Binding binding = null) : base(glue, node, binding) { ctor(); }

     //common instance .ctor body
     private void ctor()
     {

     }

  #endregion

     public override Type Contract
     {
       get { return typeof(@Agni.@Social.@Graph.@IGraphEventSystem); }
     }



  #region Contract Methods

         ///<summary>
         /// Synchronous invoker for  'Agni.Social.Graph.IGraphEventSystem.EmitEvent'.
         /// This is a two-way call per contract specification, meaning - the server sends the result back either
         ///  returning no exception or WrappedExceptionData instance.
         /// ClientCallException is thrown if the call could not be placed in the outgoing queue.
         /// RemoteException is thrown if the server generated exception during method execution.
         ///</summary>
         public void @EmitEvent(@Agni.@Social.@Graph.@Event  @evt)
         {
            var call = Async_EmitEvent(@evt);
            call.CheckVoidValue();
         }

         ///<summary>
         /// Asynchronous invoker for  'Agni.Social.Graph.IGraphEventSystem.EmitEvent'.
         /// This is a two-way call per contract specification, meaning - the server sends the result back either
         ///  returning no exception or WrappedExceptionData instance.
         /// CallSlot is returned that can be queried for CallStatus, ResponseMsg and result.
         ///</summary>
         public CallSlot Async_EmitEvent(@Agni.@Social.@Graph.@Event  @evt)
         {
            var request = new RequestAnyMsg(s_ts_CONTRACT, @s_ms_EmitEvent_0, false, RemoteInstance, new object[]{@evt});
            return DispatchCall(request);
         }



         ///<summary>
         /// Synchronous invoker for  'Agni.Social.Graph.IGraphEventSystem.Subscribe'.
         /// This is a two-way call per contract specification, meaning - the server sends the result back either
         ///  returning no exception or WrappedExceptionData instance.
         /// ClientCallException is thrown if the call could not be placed in the outgoing queue.
         /// RemoteException is thrown if the server generated exception during method execution.
         ///</summary>
         public void @Subscribe(@NFX.@DataAccess.@Distributed.@GDID  @gRecipientNode, @NFX.@DataAccess.@Distributed.@GDID  @gEmitterNode, @System.@Byte[]  @parameters)
         {
            var call = Async_Subscribe(@gRecipientNode, @gEmitterNode, @parameters);
            call.CheckVoidValue();
         }

         ///<summary>
         /// Asynchronous invoker for  'Agni.Social.Graph.IGraphEventSystem.Subscribe'.
         /// This is a two-way call per contract specification, meaning - the server sends the result back either
         ///  returning no exception or WrappedExceptionData instance.
         /// CallSlot is returned that can be queried for CallStatus, ResponseMsg and result.
         ///</summary>
         public CallSlot Async_Subscribe(@NFX.@DataAccess.@Distributed.@GDID  @gRecipientNode, @NFX.@DataAccess.@Distributed.@GDID  @gEmitterNode, @System.@Byte[] @parameters)
         {
            var request = new RequestAnyMsg(s_ts_CONTRACT, @s_ms_Subscribe_1, false, RemoteInstance, new object[]{@gRecipientNode, @gEmitterNode, @parameters});
            return DispatchCall(request);
         }



         ///<summary>
         /// Synchronous invoker for  'Agni.Social.Graph.IGraphEventSystem.Unsubscribe'.
         /// This is a two-way call per contract specification, meaning - the server sends the result back either
         ///  returning no exception or WrappedExceptionData instance.
         /// ClientCallException is thrown if the call could not be placed in the outgoing queue.
         /// RemoteException is thrown if the server generated exception during method execution.
         ///</summary>
         public void @Unsubscribe(@NFX.@DataAccess.@Distributed.@GDID  @gRecipientNode, @NFX.@DataAccess.@Distributed.@GDID  @gEmitterNode)
         {
            var call = Async_Unsubscribe(@gRecipientNode, @gEmitterNode);
            call.CheckVoidValue();
         }

         ///<summary>
         /// Asynchronous invoker for  'Agni.Social.Graph.IGraphEventSystem.Unsubscribe'.
         /// This is a two-way call per contract specification, meaning - the server sends the result back either
         ///  returning no exception or WrappedExceptionData instance.
         /// CallSlot is returned that can be queried for CallStatus, ResponseMsg and result.
         ///</summary>
         public CallSlot Async_Unsubscribe(@NFX.@DataAccess.@Distributed.@GDID  @gRecipientNode, @NFX.@DataAccess.@Distributed.@GDID  @gEmitterNode)
         {
            var request = new RequestAnyMsg(s_ts_CONTRACT, @s_ms_Unsubscribe_2, false, RemoteInstance, new object[]{@gRecipientNode, @gEmitterNode});
            return DispatchCall(request);
         }



         ///<summary>
         /// Synchronous invoker for  'Agni.Social.Graph.IGraphEventSystem.EstimateSubscriberCount'.
         /// This is a two-way call per contract specification, meaning - the server sends the result back either
         ///  returning '@System.@Int64' or WrappedExceptionData instance.
         /// ClientCallException is thrown if the call could not be placed in the outgoing queue.
         /// RemoteException is thrown if the server generated exception during method execution.
         ///</summary>
         public @System.@Int64 @EstimateSubscriberCount(@NFX.@DataAccess.@Distributed.@GDID  @gEmitterNode)
         {
            var call = Async_EstimateSubscriberCount(@gEmitterNode);
            return call.GetValue<@System.@Int64>();
         }

         ///<summary>
         /// Asynchronous invoker for  'Agni.Social.Graph.IGraphEventSystem.EstimateSubscriberCount'.
         /// This is a two-way call per contract specification, meaning - the server sends the result back either
         ///  returning no exception or WrappedExceptionData instance.
         /// CallSlot is returned that can be queried for CallStatus, ResponseMsg and result.
         ///</summary>
         public CallSlot Async_EstimateSubscriberCount(@NFX.@DataAccess.@Distributed.@GDID  @gEmitterNode)
         {
            var request = new RequestAnyMsg(s_ts_CONTRACT, @s_ms_EstimateSubscriberCount_3, false, RemoteInstance, new object[]{@gEmitterNode});
            return DispatchCall(request);
         }



         ///<summary>
         /// Synchronous invoker for  'Agni.Social.Graph.IGraphEventSystem.GetSubscribers'.
         /// This is a two-way call per contract specification, meaning - the server sends the result back either
         ///  returning '@System.@Collections.@Generic.@IEnumerable<@Agni.@Social.@Graph.@GraphNode>' or WrappedExceptionData instance.
         /// ClientCallException is thrown if the call could not be placed in the outgoing queue.
         /// RemoteException is thrown if the server generated exception during method execution.
         ///</summary>
         public @System.@Collections.@Generic.@IEnumerable<@Agni.@Social.@Graph.@GraphNode> @GetSubscribers(@NFX.@DataAccess.@Distributed.@GDID  @gEmitterNode, @System.@Int64  @start, @System.@Int32  @count)
         {
            var call = Async_GetSubscribers(@gEmitterNode, @start, @count);
            return call.GetValue<@System.@Collections.@Generic.@IEnumerable<@Agni.@Social.@Graph.@GraphNode>>();
         }

         ///<summary>
         /// Asynchronous invoker for  'Agni.Social.Graph.IGraphEventSystem.GetSubscribers'.
         /// This is a two-way call per contract specification, meaning - the server sends the result back either
         ///  returning no exception or WrappedExceptionData instance.
         /// CallSlot is returned that can be queried for CallStatus, ResponseMsg and result.
         ///</summary>
         public CallSlot Async_GetSubscribers(@NFX.@DataAccess.@Distributed.@GDID  @gEmitterNode, @System.@Int64  @start, @System.@Int32  @count)
         {
            var request = new RequestAnyMsg(s_ts_CONTRACT, @s_ms_GetSubscribers_4, false, RemoteInstance, new object[]{@gEmitterNode, @start, @count});
            return DispatchCall(request);
         }


  #endregion

  }//class
}//namespace