﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UPCNETSystemCliente.UPCNETServiceProfesor {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://Services.upcnet.upc.com/", ConfigurationName="UPCNETServiceProfesor.UPCNETServiceProfesor")]
    public interface UPCNETServiceProfesor {
        
        // CODEGEN: Parameter 'return' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://Services.upcnet.upc.com/UPCNETServiceProfesor/validarLoginRequest", ReplyAction="http://Services.upcnet.upc.com/UPCNETServiceProfesor/validarLoginResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        UPCNETSystemCliente.UPCNETServiceProfesor.validarLoginResponse validarLogin(UPCNETSystemCliente.UPCNETServiceProfesor.validarLoginRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Services.upcnet.upc.com/UPCNETServiceProfesor/validarLoginRequest", ReplyAction="http://Services.upcnet.upc.com/UPCNETServiceProfesor/validarLoginResponse")]
        System.Threading.Tasks.Task<UPCNETSystemCliente.UPCNETServiceProfesor.validarLoginResponse> validarLoginAsync(UPCNETSystemCliente.UPCNETServiceProfesor.validarLoginRequest request);
        
        // CODEGEN: Parameter 'return' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://Services.upcnet.upc.com/UPCNETServiceProfesor/getProfesorRequest", ReplyAction="http://Services.upcnet.upc.com/UPCNETServiceProfesor/getProfesorResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        UPCNETSystemCliente.UPCNETServiceProfesor.getProfesorResponse getProfesor(UPCNETSystemCliente.UPCNETServiceProfesor.getProfesorRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Services.upcnet.upc.com/UPCNETServiceProfesor/getProfesorRequest", ReplyAction="http://Services.upcnet.upc.com/UPCNETServiceProfesor/getProfesorResponse")]
        System.Threading.Tasks.Task<UPCNETSystemCliente.UPCNETServiceProfesor.getProfesorResponse> getProfesorAsync(UPCNETSystemCliente.UPCNETServiceProfesor.getProfesorRequest request);
        
        // CODEGEN: Parameter 'arg0' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://Services.upcnet.upc.com/UPCNETServiceProfesor/setProfesorRequest", ReplyAction="http://Services.upcnet.upc.com/UPCNETServiceProfesor/setProfesorResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        UPCNETSystemCliente.UPCNETServiceProfesor.setProfesorResponse setProfesor(UPCNETSystemCliente.UPCNETServiceProfesor.setProfesorRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Services.upcnet.upc.com/UPCNETServiceProfesor/setProfesorRequest", ReplyAction="http://Services.upcnet.upc.com/UPCNETServiceProfesor/setProfesorResponse")]
        System.Threading.Tasks.Task<UPCNETSystemCliente.UPCNETServiceProfesor.setProfesorResponse> setProfesorAsync(UPCNETSystemCliente.UPCNETServiceProfesor.setProfesorRequest request);
        
        // CODEGEN: Parameter 'arg0' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://Services.upcnet.upc.com/UPCNETServiceProfesor/editProfesorRequest", ReplyAction="http://Services.upcnet.upc.com/UPCNETServiceProfesor/editProfesorResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        UPCNETSystemCliente.UPCNETServiceProfesor.editProfesorResponse editProfesor(UPCNETSystemCliente.UPCNETServiceProfesor.editProfesorRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Services.upcnet.upc.com/UPCNETServiceProfesor/editProfesorRequest", ReplyAction="http://Services.upcnet.upc.com/UPCNETServiceProfesor/editProfesorResponse")]
        System.Threading.Tasks.Task<UPCNETSystemCliente.UPCNETServiceProfesor.editProfesorResponse> editProfesorAsync(UPCNETSystemCliente.UPCNETServiceProfesor.editProfesorRequest request);
        
        // CODEGEN: Parameter 'return' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://Services.upcnet.upc.com/UPCNETServiceProfesor/getProfesorByIdRequest", ReplyAction="http://Services.upcnet.upc.com/UPCNETServiceProfesor/getProfesorByIdResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        UPCNETSystemCliente.UPCNETServiceProfesor.getProfesorByIdResponse getProfesorById(UPCNETSystemCliente.UPCNETServiceProfesor.getProfesorByIdRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Services.upcnet.upc.com/UPCNETServiceProfesor/getProfesorByIdRequest", ReplyAction="http://Services.upcnet.upc.com/UPCNETServiceProfesor/getProfesorByIdResponse")]
        System.Threading.Tasks.Task<UPCNETSystemCliente.UPCNETServiceProfesor.getProfesorByIdResponse> getProfesorByIdAsync(UPCNETSystemCliente.UPCNETServiceProfesor.getProfesorByIdRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="validarLogin", WrapperNamespace="http://Services.upcnet.upc.com/", IsWrapped=true)]
    public partial class validarLoginRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://Services.upcnet.upc.com/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string arg0;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://Services.upcnet.upc.com/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string arg1;
        
        public validarLoginRequest() {
        }
        
        public validarLoginRequest(string arg0, string arg1) {
            this.arg0 = arg0;
            this.arg1 = arg1;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="validarLoginResponse", WrapperNamespace="http://Services.upcnet.upc.com/", IsWrapped=true)]
    public partial class validarLoginResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://Services.upcnet.upc.com/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool @return;
        
        public validarLoginResponse() {
        }
        
        public validarLoginResponse(bool @return) {
            this.@return = @return;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://Services.upcnet.upc.com/")]
    public partial class profesor : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string apellidoField;
        
        private string correoField;
        
        private string direccionField;
        
        private int dniField;
        
        private bool dniFieldSpecified;
        
        private int edadField;
        
        private bool edadFieldSpecified;
        
        private string idProfesorField;
        
        private string nombreField;
        
        private string passField;
        
        private double sueldoField;
        
        private bool sueldoFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string apellido {
            get {
                return this.apellidoField;
            }
            set {
                this.apellidoField = value;
                this.RaisePropertyChanged("apellido");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string correo {
            get {
                return this.correoField;
            }
            set {
                this.correoField = value;
                this.RaisePropertyChanged("correo");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string direccion {
            get {
                return this.direccionField;
            }
            set {
                this.direccionField = value;
                this.RaisePropertyChanged("direccion");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public int dni {
            get {
                return this.dniField;
            }
            set {
                this.dniField = value;
                this.RaisePropertyChanged("dni");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dniSpecified {
            get {
                return this.dniFieldSpecified;
            }
            set {
                this.dniFieldSpecified = value;
                this.RaisePropertyChanged("dniSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public int edad {
            get {
                return this.edadField;
            }
            set {
                this.edadField = value;
                this.RaisePropertyChanged("edad");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool edadSpecified {
            get {
                return this.edadFieldSpecified;
            }
            set {
                this.edadFieldSpecified = value;
                this.RaisePropertyChanged("edadSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public string idProfesor {
            get {
                return this.idProfesorField;
            }
            set {
                this.idProfesorField = value;
                this.RaisePropertyChanged("idProfesor");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public string nombre {
            get {
                return this.nombreField;
            }
            set {
                this.nombreField = value;
                this.RaisePropertyChanged("nombre");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=7)]
        public string pass {
            get {
                return this.passField;
            }
            set {
                this.passField = value;
                this.RaisePropertyChanged("pass");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=8)]
        public double sueldo {
            get {
                return this.sueldoField;
            }
            set {
                this.sueldoField = value;
                this.RaisePropertyChanged("sueldo");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool sueldoSpecified {
            get {
                return this.sueldoFieldSpecified;
            }
            set {
                this.sueldoFieldSpecified = value;
                this.RaisePropertyChanged("sueldoSpecified");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getProfesor", WrapperNamespace="http://Services.upcnet.upc.com/", IsWrapped=true)]
    public partial class getProfesorRequest {
        
        public getProfesorRequest() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getProfesorResponse", WrapperNamespace="http://Services.upcnet.upc.com/", IsWrapped=true)]
    public partial class getProfesorResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://Services.upcnet.upc.com/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public UPCNETSystemCliente.UPCNETServiceProfesor.profesor[] @return;
        
        public getProfesorResponse() {
        }
        
        public getProfesorResponse(UPCNETSystemCliente.UPCNETServiceProfesor.profesor[] @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="setProfesor", WrapperNamespace="http://Services.upcnet.upc.com/", IsWrapped=true)]
    public partial class setProfesorRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://Services.upcnet.upc.com/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public UPCNETSystemCliente.UPCNETServiceProfesor.profesor arg0;
        
        public setProfesorRequest() {
        }
        
        public setProfesorRequest(UPCNETSystemCliente.UPCNETServiceProfesor.profesor arg0) {
            this.arg0 = arg0;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="setProfesorResponse", WrapperNamespace="http://Services.upcnet.upc.com/", IsWrapped=true)]
    public partial class setProfesorResponse {
        
        public setProfesorResponse() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="editProfesor", WrapperNamespace="http://Services.upcnet.upc.com/", IsWrapped=true)]
    public partial class editProfesorRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://Services.upcnet.upc.com/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public UPCNETSystemCliente.UPCNETServiceProfesor.profesor arg0;
        
        public editProfesorRequest() {
        }
        
        public editProfesorRequest(UPCNETSystemCliente.UPCNETServiceProfesor.profesor arg0) {
            this.arg0 = arg0;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="editProfesorResponse", WrapperNamespace="http://Services.upcnet.upc.com/", IsWrapped=true)]
    public partial class editProfesorResponse {
        
        public editProfesorResponse() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getProfesorById", WrapperNamespace="http://Services.upcnet.upc.com/", IsWrapped=true)]
    public partial class getProfesorByIdRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://Services.upcnet.upc.com/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string arg0;
        
        public getProfesorByIdRequest() {
        }
        
        public getProfesorByIdRequest(string arg0) {
            this.arg0 = arg0;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getProfesorByIdResponse", WrapperNamespace="http://Services.upcnet.upc.com/", IsWrapped=true)]
    public partial class getProfesorByIdResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://Services.upcnet.upc.com/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public UPCNETSystemCliente.UPCNETServiceProfesor.profesor @return;
        
        public getProfesorByIdResponse() {
        }
        
        public getProfesorByIdResponse(UPCNETSystemCliente.UPCNETServiceProfesor.profesor @return) {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface UPCNETServiceProfesorChannel : UPCNETSystemCliente.UPCNETServiceProfesor.UPCNETServiceProfesor, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class UPCNETServiceProfesorClient : System.ServiceModel.ClientBase<UPCNETSystemCliente.UPCNETServiceProfesor.UPCNETServiceProfesor>, UPCNETSystemCliente.UPCNETServiceProfesor.UPCNETServiceProfesor {
        
        public UPCNETServiceProfesorClient() {
        }
        
        public UPCNETServiceProfesorClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public UPCNETServiceProfesorClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UPCNETServiceProfesorClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UPCNETServiceProfesorClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        UPCNETSystemCliente.UPCNETServiceProfesor.validarLoginResponse UPCNETSystemCliente.UPCNETServiceProfesor.UPCNETServiceProfesor.validarLogin(UPCNETSystemCliente.UPCNETServiceProfesor.validarLoginRequest request) {
            return base.Channel.validarLogin(request);
        }
        
        public bool validarLogin(string arg0, string arg1) {
            UPCNETSystemCliente.UPCNETServiceProfesor.validarLoginRequest inValue = new UPCNETSystemCliente.UPCNETServiceProfesor.validarLoginRequest();
            inValue.arg0 = arg0;
            inValue.arg1 = arg1;
            UPCNETSystemCliente.UPCNETServiceProfesor.validarLoginResponse retVal = ((UPCNETSystemCliente.UPCNETServiceProfesor.UPCNETServiceProfesor)(this)).validarLogin(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<UPCNETSystemCliente.UPCNETServiceProfesor.validarLoginResponse> UPCNETSystemCliente.UPCNETServiceProfesor.UPCNETServiceProfesor.validarLoginAsync(UPCNETSystemCliente.UPCNETServiceProfesor.validarLoginRequest request) {
            return base.Channel.validarLoginAsync(request);
        }
        
        public System.Threading.Tasks.Task<UPCNETSystemCliente.UPCNETServiceProfesor.validarLoginResponse> validarLoginAsync(string arg0, string arg1) {
            UPCNETSystemCliente.UPCNETServiceProfesor.validarLoginRequest inValue = new UPCNETSystemCliente.UPCNETServiceProfesor.validarLoginRequest();
            inValue.arg0 = arg0;
            inValue.arg1 = arg1;
            return ((UPCNETSystemCliente.UPCNETServiceProfesor.UPCNETServiceProfesor)(this)).validarLoginAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        UPCNETSystemCliente.UPCNETServiceProfesor.getProfesorResponse UPCNETSystemCliente.UPCNETServiceProfesor.UPCNETServiceProfesor.getProfesor(UPCNETSystemCliente.UPCNETServiceProfesor.getProfesorRequest request) {
            return base.Channel.getProfesor(request);
        }
        
        public UPCNETSystemCliente.UPCNETServiceProfesor.profesor[] getProfesor() {
            UPCNETSystemCliente.UPCNETServiceProfesor.getProfesorRequest inValue = new UPCNETSystemCliente.UPCNETServiceProfesor.getProfesorRequest();
            UPCNETSystemCliente.UPCNETServiceProfesor.getProfesorResponse retVal = ((UPCNETSystemCliente.UPCNETServiceProfesor.UPCNETServiceProfesor)(this)).getProfesor(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<UPCNETSystemCliente.UPCNETServiceProfesor.getProfesorResponse> UPCNETSystemCliente.UPCNETServiceProfesor.UPCNETServiceProfesor.getProfesorAsync(UPCNETSystemCliente.UPCNETServiceProfesor.getProfesorRequest request) {
            return base.Channel.getProfesorAsync(request);
        }
        
        public System.Threading.Tasks.Task<UPCNETSystemCliente.UPCNETServiceProfesor.getProfesorResponse> getProfesorAsync() {
            UPCNETSystemCliente.UPCNETServiceProfesor.getProfesorRequest inValue = new UPCNETSystemCliente.UPCNETServiceProfesor.getProfesorRequest();
            return ((UPCNETSystemCliente.UPCNETServiceProfesor.UPCNETServiceProfesor)(this)).getProfesorAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        UPCNETSystemCliente.UPCNETServiceProfesor.setProfesorResponse UPCNETSystemCliente.UPCNETServiceProfesor.UPCNETServiceProfesor.setProfesor(UPCNETSystemCliente.UPCNETServiceProfesor.setProfesorRequest request) {
            return base.Channel.setProfesor(request);
        }
        
        public void setProfesor(UPCNETSystemCliente.UPCNETServiceProfesor.profesor arg0) {
            UPCNETSystemCliente.UPCNETServiceProfesor.setProfesorRequest inValue = new UPCNETSystemCliente.UPCNETServiceProfesor.setProfesorRequest();
            inValue.arg0 = arg0;
            UPCNETSystemCliente.UPCNETServiceProfesor.setProfesorResponse retVal = ((UPCNETSystemCliente.UPCNETServiceProfesor.UPCNETServiceProfesor)(this)).setProfesor(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<UPCNETSystemCliente.UPCNETServiceProfesor.setProfesorResponse> UPCNETSystemCliente.UPCNETServiceProfesor.UPCNETServiceProfesor.setProfesorAsync(UPCNETSystemCliente.UPCNETServiceProfesor.setProfesorRequest request) {
            return base.Channel.setProfesorAsync(request);
        }
        
        public System.Threading.Tasks.Task<UPCNETSystemCliente.UPCNETServiceProfesor.setProfesorResponse> setProfesorAsync(UPCNETSystemCliente.UPCNETServiceProfesor.profesor arg0) {
            UPCNETSystemCliente.UPCNETServiceProfesor.setProfesorRequest inValue = new UPCNETSystemCliente.UPCNETServiceProfesor.setProfesorRequest();
            inValue.arg0 = arg0;
            return ((UPCNETSystemCliente.UPCNETServiceProfesor.UPCNETServiceProfesor)(this)).setProfesorAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        UPCNETSystemCliente.UPCNETServiceProfesor.editProfesorResponse UPCNETSystemCliente.UPCNETServiceProfesor.UPCNETServiceProfesor.editProfesor(UPCNETSystemCliente.UPCNETServiceProfesor.editProfesorRequest request) {
            return base.Channel.editProfesor(request);
        }
        
        public void editProfesor(UPCNETSystemCliente.UPCNETServiceProfesor.profesor arg0) {
            UPCNETSystemCliente.UPCNETServiceProfesor.editProfesorRequest inValue = new UPCNETSystemCliente.UPCNETServiceProfesor.editProfesorRequest();
            inValue.arg0 = arg0;
            UPCNETSystemCliente.UPCNETServiceProfesor.editProfesorResponse retVal = ((UPCNETSystemCliente.UPCNETServiceProfesor.UPCNETServiceProfesor)(this)).editProfesor(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<UPCNETSystemCliente.UPCNETServiceProfesor.editProfesorResponse> UPCNETSystemCliente.UPCNETServiceProfesor.UPCNETServiceProfesor.editProfesorAsync(UPCNETSystemCliente.UPCNETServiceProfesor.editProfesorRequest request) {
            return base.Channel.editProfesorAsync(request);
        }
        
        public System.Threading.Tasks.Task<UPCNETSystemCliente.UPCNETServiceProfesor.editProfesorResponse> editProfesorAsync(UPCNETSystemCliente.UPCNETServiceProfesor.profesor arg0) {
            UPCNETSystemCliente.UPCNETServiceProfesor.editProfesorRequest inValue = new UPCNETSystemCliente.UPCNETServiceProfesor.editProfesorRequest();
            inValue.arg0 = arg0;
            return ((UPCNETSystemCliente.UPCNETServiceProfesor.UPCNETServiceProfesor)(this)).editProfesorAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        UPCNETSystemCliente.UPCNETServiceProfesor.getProfesorByIdResponse UPCNETSystemCliente.UPCNETServiceProfesor.UPCNETServiceProfesor.getProfesorById(UPCNETSystemCliente.UPCNETServiceProfesor.getProfesorByIdRequest request) {
            return base.Channel.getProfesorById(request);
        }
        
        public UPCNETSystemCliente.UPCNETServiceProfesor.profesor getProfesorById(string arg0) {
            UPCNETSystemCliente.UPCNETServiceProfesor.getProfesorByIdRequest inValue = new UPCNETSystemCliente.UPCNETServiceProfesor.getProfesorByIdRequest();
            inValue.arg0 = arg0;
            UPCNETSystemCliente.UPCNETServiceProfesor.getProfesorByIdResponse retVal = ((UPCNETSystemCliente.UPCNETServiceProfesor.UPCNETServiceProfesor)(this)).getProfesorById(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<UPCNETSystemCliente.UPCNETServiceProfesor.getProfesorByIdResponse> UPCNETSystemCliente.UPCNETServiceProfesor.UPCNETServiceProfesor.getProfesorByIdAsync(UPCNETSystemCliente.UPCNETServiceProfesor.getProfesorByIdRequest request) {
            return base.Channel.getProfesorByIdAsync(request);
        }
        
        public System.Threading.Tasks.Task<UPCNETSystemCliente.UPCNETServiceProfesor.getProfesorByIdResponse> getProfesorByIdAsync(string arg0) {
            UPCNETSystemCliente.UPCNETServiceProfesor.getProfesorByIdRequest inValue = new UPCNETSystemCliente.UPCNETServiceProfesor.getProfesorByIdRequest();
            inValue.arg0 = arg0;
            return ((UPCNETSystemCliente.UPCNETServiceProfesor.UPCNETServiceProfesor)(this)).getProfesorByIdAsync(inValue);
        }
    }
}
