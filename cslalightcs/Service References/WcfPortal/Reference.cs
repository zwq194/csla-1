﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.1433
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Csla.WcfPortal {
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Runtime.Serialization.DataContractAttribute(Name="CriteriaRequest", Namespace="http://schemas.datacontract.org/2004/07/Csla.Server.Hosts.Silverlight")]
    public partial class CriteriaRequest : object, System.ComponentModel.INotifyPropertyChanged {
        
        private byte[] CriteriaDataField;
        
        private string TypeNameField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte[] CriteriaData {
            get {
                return this.CriteriaDataField;
            }
            set {
                if ((object.ReferenceEquals(this.CriteriaDataField, value) != true)) {
                    this.CriteriaDataField = value;
                    this.RaisePropertyChanged("CriteriaData");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TypeName {
            get {
                return this.TypeNameField;
            }
            set {
                if ((object.ReferenceEquals(this.TypeNameField, value) != true)) {
                    this.TypeNameField = value;
                    this.RaisePropertyChanged("TypeName");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Runtime.Serialization.DataContractAttribute(Name="WcfResponse", Namespace="http://schemas.datacontract.org/2004/07/Csla.Server.Hosts.Silverlight")]
    public partial class WcfResponse : object, System.ComponentModel.INotifyPropertyChanged {
        
        private Csla.WcfPortal.WcfErrorInfo ErrorDataField;
        
        private byte[] ObjectDataField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Csla.WcfPortal.WcfErrorInfo ErrorData {
            get {
                return this.ErrorDataField;
            }
            set {
                if ((object.ReferenceEquals(this.ErrorDataField, value) != true)) {
                    this.ErrorDataField = value;
                    this.RaisePropertyChanged("ErrorData");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte[] ObjectData {
            get {
                return this.ObjectDataField;
            }
            set {
                if ((object.ReferenceEquals(this.ObjectDataField, value) != true)) {
                    this.ObjectDataField = value;
                    this.RaisePropertyChanged("ObjectData");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Runtime.Serialization.DataContractAttribute(Name="WcfErrorInfo", Namespace="http://schemas.datacontract.org/2004/07/Csla.Server.Hosts.Silverlight")]
    public partial class WcfErrorInfo : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string ExceptionTypeNameField;
        
        private Csla.WcfPortal.WcfErrorInfo InnerErrorField;
        
        private string MessageField;
        
        private string SourceField;
        
        private string StackTraceField;
        
        private string TargetSiteNameField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ExceptionTypeName {
            get {
                return this.ExceptionTypeNameField;
            }
            set {
                if ((object.ReferenceEquals(this.ExceptionTypeNameField, value) != true)) {
                    this.ExceptionTypeNameField = value;
                    this.RaisePropertyChanged("ExceptionTypeName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Csla.WcfPortal.WcfErrorInfo InnerError {
            get {
                return this.InnerErrorField;
            }
            set {
                if ((object.ReferenceEquals(this.InnerErrorField, value) != true)) {
                    this.InnerErrorField = value;
                    this.RaisePropertyChanged("InnerError");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Message {
            get {
                return this.MessageField;
            }
            set {
                if ((object.ReferenceEquals(this.MessageField, value) != true)) {
                    this.MessageField = value;
                    this.RaisePropertyChanged("Message");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Source {
            get {
                return this.SourceField;
            }
            set {
                if ((object.ReferenceEquals(this.SourceField, value) != true)) {
                    this.SourceField = value;
                    this.RaisePropertyChanged("Source");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StackTrace {
            get {
                return this.StackTraceField;
            }
            set {
                if ((object.ReferenceEquals(this.StackTraceField, value) != true)) {
                    this.StackTraceField = value;
                    this.RaisePropertyChanged("StackTrace");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TargetSiteName {
            get {
                return this.TargetSiteNameField;
            }
            set {
                if ((object.ReferenceEquals(this.TargetSiteNameField, value) != true)) {
                    this.TargetSiteNameField = value;
                    this.RaisePropertyChanged("TargetSiteName");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Runtime.Serialization.DataContractAttribute(Name="UpdateRequest", Namespace="http://schemas.datacontract.org/2004/07/Csla.Server.Hosts.Silverlight")]
    public partial class UpdateRequest : object, System.ComponentModel.INotifyPropertyChanged {
        
        private byte[] ObjectDataField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte[] ObjectData {
            get {
                return this.ObjectDataField;
            }
            set {
                if ((object.ReferenceEquals(this.ObjectDataField, value) != true)) {
                    this.ObjectDataField = value;
                    this.RaisePropertyChanged("ObjectData");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://ws.lhotka.net/WcfDataPortal")]
    public interface IWcfPortal {
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://ws.lhotka.net/WcfDataPortal/IWcfPortal/Create", ReplyAction="http://ws.lhotka.net/WcfDataPortal/IWcfPortal/CreateResponse")]
        System.IAsyncResult BeginCreate(Csla.WcfPortal.CriteriaRequest request, System.AsyncCallback callback, object asyncState);
        
        Csla.WcfPortal.WcfResponse EndCreate(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://ws.lhotka.net/WcfDataPortal/IWcfPortal/Fetch", ReplyAction="http://ws.lhotka.net/WcfDataPortal/IWcfPortal/FetchResponse")]
        System.IAsyncResult BeginFetch(Csla.WcfPortal.CriteriaRequest request, System.AsyncCallback callback, object asyncState);
        
        Csla.WcfPortal.WcfResponse EndFetch(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://ws.lhotka.net/WcfDataPortal/IWcfPortal/Update", ReplyAction="http://ws.lhotka.net/WcfDataPortal/IWcfPortal/UpdateResponse")]
        System.IAsyncResult BeginUpdate(Csla.WcfPortal.UpdateRequest request, System.AsyncCallback callback, object asyncState);
        
        Csla.WcfPortal.WcfResponse EndUpdate(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://ws.lhotka.net/WcfDataPortal/IWcfPortal/Delete", ReplyAction="http://ws.lhotka.net/WcfDataPortal/IWcfPortal/DeleteResponse")]
        System.IAsyncResult BeginDelete(Csla.WcfPortal.CriteriaRequest request, System.AsyncCallback callback, object asyncState);
        
        Csla.WcfPortal.WcfResponse EndDelete(System.IAsyncResult result);
    }
    
    public interface IWcfPortalChannel : Csla.WcfPortal.IWcfPortal, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    public partial class CreateCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public CreateCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public Csla.WcfPortal.WcfResponse Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((Csla.WcfPortal.WcfResponse)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    public partial class FetchCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public FetchCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public Csla.WcfPortal.WcfResponse Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((Csla.WcfPortal.WcfResponse)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    public partial class UpdateCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public UpdateCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public Csla.WcfPortal.WcfResponse Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((Csla.WcfPortal.WcfResponse)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    public partial class DeleteCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public DeleteCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public Csla.WcfPortal.WcfResponse Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((Csla.WcfPortal.WcfResponse)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    public partial class WcfPortalClient : System.ServiceModel.ClientBase<Csla.WcfPortal.IWcfPortal>, Csla.WcfPortal.IWcfPortal {
        
        private BeginOperationDelegate onBeginCreateDelegate;
        
        private EndOperationDelegate onEndCreateDelegate;
        
        private System.Threading.SendOrPostCallback onCreateCompletedDelegate;
        
        private BeginOperationDelegate onBeginFetchDelegate;
        
        private EndOperationDelegate onEndFetchDelegate;
        
        private System.Threading.SendOrPostCallback onFetchCompletedDelegate;
        
        private BeginOperationDelegate onBeginUpdateDelegate;
        
        private EndOperationDelegate onEndUpdateDelegate;
        
        private System.Threading.SendOrPostCallback onUpdateCompletedDelegate;
        
        private BeginOperationDelegate onBeginDeleteDelegate;
        
        private EndOperationDelegate onEndDeleteDelegate;
        
        private System.Threading.SendOrPostCallback onDeleteCompletedDelegate;
        
        private static System.ServiceModel.Channels.Binding defaultBinding = new System.ServiceModel.BasicHttpBinding();
        
        private static System.ServiceModel.EndpointAddress defaultAddress = new System.ServiceModel.EndpointAddress("http://localhost:1051/SilverlightApplication1_Web/WcfPortal.svc");
        
        public WcfPortalClient() : 
                this(defaultBinding, defaultAddress) {
        }
        
        public WcfPortalClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public event System.EventHandler<CreateCompletedEventArgs> CreateCompleted;
        
        public event System.EventHandler<FetchCompletedEventArgs> FetchCompleted;
        
        public event System.EventHandler<UpdateCompletedEventArgs> UpdateCompleted;
        
        public event System.EventHandler<DeleteCompletedEventArgs> DeleteCompleted;
        
        System.IAsyncResult Csla.WcfPortal.IWcfPortal.BeginCreate(Csla.WcfPortal.CriteriaRequest request, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginCreate(request, callback, asyncState);
        }
        
        Csla.WcfPortal.WcfResponse Csla.WcfPortal.IWcfPortal.EndCreate(System.IAsyncResult result) {
            return base.Channel.EndCreate(result);
        }
        
        private System.IAsyncResult OnBeginCreate(object[] inValues, System.AsyncCallback callback, object asyncState) {
            Csla.WcfPortal.CriteriaRequest request = ((Csla.WcfPortal.CriteriaRequest)(inValues[0]));
            return ((Csla.WcfPortal.IWcfPortal)(this)).BeginCreate(request, callback, asyncState);
        }
        
        private object[] OnEndCreate(System.IAsyncResult result) {
            Csla.WcfPortal.WcfResponse retVal = ((Csla.WcfPortal.IWcfPortal)(this)).EndCreate(result);
            return new object[] {
                    retVal};
        }
        
        private void OnCreateCompleted(object state) {
            if ((this.CreateCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.CreateCompleted(this, new CreateCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void CreateAsync(Csla.WcfPortal.CriteriaRequest request) {
            this.CreateAsync(request, null);
        }
        
        public void CreateAsync(Csla.WcfPortal.CriteriaRequest request, object userState) {
            if ((this.onBeginCreateDelegate == null)) {
                this.onBeginCreateDelegate = new BeginOperationDelegate(this.OnBeginCreate);
            }
            if ((this.onEndCreateDelegate == null)) {
                this.onEndCreateDelegate = new EndOperationDelegate(this.OnEndCreate);
            }
            if ((this.onCreateCompletedDelegate == null)) {
                this.onCreateCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnCreateCompleted);
            }
            base.InvokeAsync(this.onBeginCreateDelegate, new object[] {
                        request}, this.onEndCreateDelegate, this.onCreateCompletedDelegate, userState);
        }
        
        System.IAsyncResult Csla.WcfPortal.IWcfPortal.BeginFetch(Csla.WcfPortal.CriteriaRequest request, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginFetch(request, callback, asyncState);
        }
        
        Csla.WcfPortal.WcfResponse Csla.WcfPortal.IWcfPortal.EndFetch(System.IAsyncResult result) {
            return base.Channel.EndFetch(result);
        }
        
        private System.IAsyncResult OnBeginFetch(object[] inValues, System.AsyncCallback callback, object asyncState) {
            Csla.WcfPortal.CriteriaRequest request = ((Csla.WcfPortal.CriteriaRequest)(inValues[0]));
            return ((Csla.WcfPortal.IWcfPortal)(this)).BeginFetch(request, callback, asyncState);
        }
        
        private object[] OnEndFetch(System.IAsyncResult result) {
            Csla.WcfPortal.WcfResponse retVal = ((Csla.WcfPortal.IWcfPortal)(this)).EndFetch(result);
            return new object[] {
                    retVal};
        }
        
        private void OnFetchCompleted(object state) {
            if ((this.FetchCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.FetchCompleted(this, new FetchCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void FetchAsync(Csla.WcfPortal.CriteriaRequest request) {
            this.FetchAsync(request, null);
        }
        
        public void FetchAsync(Csla.WcfPortal.CriteriaRequest request, object userState) {
            if ((this.onBeginFetchDelegate == null)) {
                this.onBeginFetchDelegate = new BeginOperationDelegate(this.OnBeginFetch);
            }
            if ((this.onEndFetchDelegate == null)) {
                this.onEndFetchDelegate = new EndOperationDelegate(this.OnEndFetch);
            }
            if ((this.onFetchCompletedDelegate == null)) {
                this.onFetchCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnFetchCompleted);
            }
            base.InvokeAsync(this.onBeginFetchDelegate, new object[] {
                        request}, this.onEndFetchDelegate, this.onFetchCompletedDelegate, userState);
        }
        
        System.IAsyncResult Csla.WcfPortal.IWcfPortal.BeginUpdate(Csla.WcfPortal.UpdateRequest request, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginUpdate(request, callback, asyncState);
        }
        
        Csla.WcfPortal.WcfResponse Csla.WcfPortal.IWcfPortal.EndUpdate(System.IAsyncResult result) {
            return base.Channel.EndUpdate(result);
        }
        
        private System.IAsyncResult OnBeginUpdate(object[] inValues, System.AsyncCallback callback, object asyncState) {
            Csla.WcfPortal.UpdateRequest request = ((Csla.WcfPortal.UpdateRequest)(inValues[0]));
            return ((Csla.WcfPortal.IWcfPortal)(this)).BeginUpdate(request, callback, asyncState);
        }
        
        private object[] OnEndUpdate(System.IAsyncResult result) {
            Csla.WcfPortal.WcfResponse retVal = ((Csla.WcfPortal.IWcfPortal)(this)).EndUpdate(result);
            return new object[] {
                    retVal};
        }
        
        private void OnUpdateCompleted(object state) {
            if ((this.UpdateCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.UpdateCompleted(this, new UpdateCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void UpdateAsync(Csla.WcfPortal.UpdateRequest request) {
            this.UpdateAsync(request, null);
        }
        
        public void UpdateAsync(Csla.WcfPortal.UpdateRequest request, object userState) {
            if ((this.onBeginUpdateDelegate == null)) {
                this.onBeginUpdateDelegate = new BeginOperationDelegate(this.OnBeginUpdate);
            }
            if ((this.onEndUpdateDelegate == null)) {
                this.onEndUpdateDelegate = new EndOperationDelegate(this.OnEndUpdate);
            }
            if ((this.onUpdateCompletedDelegate == null)) {
                this.onUpdateCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnUpdateCompleted);
            }
            base.InvokeAsync(this.onBeginUpdateDelegate, new object[] {
                        request}, this.onEndUpdateDelegate, this.onUpdateCompletedDelegate, userState);
        }
        
        System.IAsyncResult Csla.WcfPortal.IWcfPortal.BeginDelete(Csla.WcfPortal.CriteriaRequest request, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginDelete(request, callback, asyncState);
        }
        
        Csla.WcfPortal.WcfResponse Csla.WcfPortal.IWcfPortal.EndDelete(System.IAsyncResult result) {
            return base.Channel.EndDelete(result);
        }
        
        private System.IAsyncResult OnBeginDelete(object[] inValues, System.AsyncCallback callback, object asyncState) {
            Csla.WcfPortal.CriteriaRequest request = ((Csla.WcfPortal.CriteriaRequest)(inValues[0]));
            return ((Csla.WcfPortal.IWcfPortal)(this)).BeginDelete(request, callback, asyncState);
        }
        
        private object[] OnEndDelete(System.IAsyncResult result) {
            Csla.WcfPortal.WcfResponse retVal = ((Csla.WcfPortal.IWcfPortal)(this)).EndDelete(result);
            return new object[] {
                    retVal};
        }
        
        private void OnDeleteCompleted(object state) {
            if ((this.DeleteCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.DeleteCompleted(this, new DeleteCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void DeleteAsync(Csla.WcfPortal.CriteriaRequest request) {
            this.DeleteAsync(request, null);
        }
        
        public void DeleteAsync(Csla.WcfPortal.CriteriaRequest request, object userState) {
            if ((this.onBeginDeleteDelegate == null)) {
                this.onBeginDeleteDelegate = new BeginOperationDelegate(this.OnBeginDelete);
            }
            if ((this.onEndDeleteDelegate == null)) {
                this.onEndDeleteDelegate = new EndOperationDelegate(this.OnEndDelete);
            }
            if ((this.onDeleteCompletedDelegate == null)) {
                this.onDeleteCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnDeleteCompleted);
            }
            base.InvokeAsync(this.onBeginDeleteDelegate, new object[] {
                        request}, this.onEndDeleteDelegate, this.onDeleteCompletedDelegate, userState);
        }
        
        protected override Csla.WcfPortal.IWcfPortal CreateChannel() {
            return new WcfPortalClientChannel(this);
        }
        
        private class WcfPortalClientChannel : ChannelBase<Csla.WcfPortal.IWcfPortal>, Csla.WcfPortal.IWcfPortal {
            
            public WcfPortalClientChannel(System.ServiceModel.ClientBase<Csla.WcfPortal.IWcfPortal> client) : 
                    base(client) {
            }
            
            public System.IAsyncResult BeginCreate(Csla.WcfPortal.CriteriaRequest request, System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[1];
                _args[0] = request;
                System.IAsyncResult _result = base.BeginInvoke("Create", _args, callback, asyncState);
                return _result;
            }
            
            public Csla.WcfPortal.WcfResponse EndCreate(System.IAsyncResult result) {
                object[] _args = new object[0];
                Csla.WcfPortal.WcfResponse _result = ((Csla.WcfPortal.WcfResponse)(base.EndInvoke("Create", _args, result)));
                return _result;
            }
            
            public System.IAsyncResult BeginFetch(Csla.WcfPortal.CriteriaRequest request, System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[1];
                _args[0] = request;
                System.IAsyncResult _result = base.BeginInvoke("Fetch", _args, callback, asyncState);
                return _result;
            }
            
            public Csla.WcfPortal.WcfResponse EndFetch(System.IAsyncResult result) {
                object[] _args = new object[0];
                Csla.WcfPortal.WcfResponse _result = ((Csla.WcfPortal.WcfResponse)(base.EndInvoke("Fetch", _args, result)));
                return _result;
            }
            
            public System.IAsyncResult BeginUpdate(Csla.WcfPortal.UpdateRequest request, System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[1];
                _args[0] = request;
                System.IAsyncResult _result = base.BeginInvoke("Update", _args, callback, asyncState);
                return _result;
            }
            
            public Csla.WcfPortal.WcfResponse EndUpdate(System.IAsyncResult result) {
                object[] _args = new object[0];
                Csla.WcfPortal.WcfResponse _result = ((Csla.WcfPortal.WcfResponse)(base.EndInvoke("Update", _args, result)));
                return _result;
            }
            
            public System.IAsyncResult BeginDelete(Csla.WcfPortal.CriteriaRequest request, System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[1];
                _args[0] = request;
                System.IAsyncResult _result = base.BeginInvoke("Delete", _args, callback, asyncState);
                return _result;
            }
            
            public Csla.WcfPortal.WcfResponse EndDelete(System.IAsyncResult result) {
                object[] _args = new object[0];
                Csla.WcfPortal.WcfResponse _result = ((Csla.WcfPortal.WcfResponse)(base.EndInvoke("Delete", _args, result)));
                return _result;
            }
        }
    }
}
