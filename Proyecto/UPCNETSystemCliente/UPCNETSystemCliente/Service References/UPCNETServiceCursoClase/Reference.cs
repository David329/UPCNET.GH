﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UPCNETSystemCliente.UPCNETServiceCursoClase {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://Services.upcnet.upc.com/", ConfigurationName="UPCNETServiceCursoClase.UPCNETServiceCursoClase")]
    public interface UPCNETServiceCursoClase {
        
        // CODEGEN: Parameter 'return' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://Services.upcnet.upc.com/UPCNETServiceCursoClase/helloRequest", ReplyAction="http://Services.upcnet.upc.com/UPCNETServiceCursoClase/helloResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        UPCNETSystemCliente.UPCNETServiceCursoClase.helloResponse hello(UPCNETSystemCliente.UPCNETServiceCursoClase.helloRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Services.upcnet.upc.com/UPCNETServiceCursoClase/helloRequest", ReplyAction="http://Services.upcnet.upc.com/UPCNETServiceCursoClase/helloResponse")]
        System.Threading.Tasks.Task<UPCNETSystemCliente.UPCNETServiceCursoClase.helloResponse> helloAsync(UPCNETSystemCliente.UPCNETServiceCursoClase.helloRequest request);
        
        // CODEGEN: Parameter 'return' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://Services.upcnet.upc.com/UPCNETServiceCursoClase/getCursoClasesRequest", ReplyAction="http://Services.upcnet.upc.com/UPCNETServiceCursoClase/getCursoClasesResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        UPCNETSystemCliente.UPCNETServiceCursoClase.getCursoClasesResponse getCursoClases(UPCNETSystemCliente.UPCNETServiceCursoClase.getCursoClasesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Services.upcnet.upc.com/UPCNETServiceCursoClase/getCursoClasesRequest", ReplyAction="http://Services.upcnet.upc.com/UPCNETServiceCursoClase/getCursoClasesResponse")]
        System.Threading.Tasks.Task<UPCNETSystemCliente.UPCNETServiceCursoClase.getCursoClasesResponse> getCursoClasesAsync(UPCNETSystemCliente.UPCNETServiceCursoClase.getCursoClasesRequest request);
        
        // CODEGEN: Parameter 'arg0' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://Services.upcnet.upc.com/UPCNETServiceCursoClase/setCursoClaseRequest", ReplyAction="http://Services.upcnet.upc.com/UPCNETServiceCursoClase/setCursoClaseResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        UPCNETSystemCliente.UPCNETServiceCursoClase.setCursoClaseResponse setCursoClase(UPCNETSystemCliente.UPCNETServiceCursoClase.setCursoClaseRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Services.upcnet.upc.com/UPCNETServiceCursoClase/setCursoClaseRequest", ReplyAction="http://Services.upcnet.upc.com/UPCNETServiceCursoClase/setCursoClaseResponse")]
        System.Threading.Tasks.Task<UPCNETSystemCliente.UPCNETServiceCursoClase.setCursoClaseResponse> setCursoClaseAsync(UPCNETSystemCliente.UPCNETServiceCursoClase.setCursoClaseRequest request);
        
        // CODEGEN: Parameter 'return' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://Services.upcnet.upc.com/UPCNETServiceCursoClase/getCursoClaseByIdRequest", ReplyAction="http://Services.upcnet.upc.com/UPCNETServiceCursoClase/getCursoClaseByIdResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        UPCNETSystemCliente.UPCNETServiceCursoClase.getCursoClaseByIdResponse getCursoClaseById(UPCNETSystemCliente.UPCNETServiceCursoClase.getCursoClaseByIdRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Services.upcnet.upc.com/UPCNETServiceCursoClase/getCursoClaseByIdRequest", ReplyAction="http://Services.upcnet.upc.com/UPCNETServiceCursoClase/getCursoClaseByIdResponse")]
        System.Threading.Tasks.Task<UPCNETSystemCliente.UPCNETServiceCursoClase.getCursoClaseByIdResponse> getCursoClaseByIdAsync(UPCNETSystemCliente.UPCNETServiceCursoClase.getCursoClaseByIdRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="hello", WrapperNamespace="http://Services.upcnet.upc.com/", IsWrapped=true)]
    public partial class helloRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://Services.upcnet.upc.com/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string name;
        
        public helloRequest() {
        }
        
        public helloRequest(string name) {
            this.name = name;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="helloResponse", WrapperNamespace="http://Services.upcnet.upc.com/", IsWrapped=true)]
    public partial class helloResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://Services.upcnet.upc.com/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string @return;
        
        public helloResponse() {
        }
        
        public helloResponse(string @return) {
            this.@return = @return;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://Services.upcnet.upc.com/")]
    public partial class cursoClaseReporte : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string alumnoApellidoField;
        
        private string alumnoNombreField;
        
        private string cursoNombreField;
        
        private string diaField;
        
        private string horaFinField;
        
        private string horaIniField;
        
        private string profesorApellidoField;
        
        private string profesorNombreField;
        
        private string iDClaseField;
        
        private string iDCursoField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string alumnoApellido {
            get {
                return this.alumnoApellidoField;
            }
            set {
                this.alumnoApellidoField = value;
                this.RaisePropertyChanged("alumnoApellido");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string alumnoNombre {
            get {
                return this.alumnoNombreField;
            }
            set {
                this.alumnoNombreField = value;
                this.RaisePropertyChanged("alumnoNombre");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string cursoNombre {
            get {
                return this.cursoNombreField;
            }
            set {
                this.cursoNombreField = value;
                this.RaisePropertyChanged("cursoNombre");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string dia {
            get {
                return this.diaField;
            }
            set {
                this.diaField = value;
                this.RaisePropertyChanged("dia");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public string horaFin {
            get {
                return this.horaFinField;
            }
            set {
                this.horaFinField = value;
                this.RaisePropertyChanged("horaFin");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public string horaIni {
            get {
                return this.horaIniField;
            }
            set {
                this.horaIniField = value;
                this.RaisePropertyChanged("horaIni");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public string profesorApellido {
            get {
                return this.profesorApellidoField;
            }
            set {
                this.profesorApellidoField = value;
                this.RaisePropertyChanged("profesorApellido");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=7)]
        public string profesorNombre {
            get {
                return this.profesorNombreField;
            }
            set {
                this.profesorNombreField = value;
                this.RaisePropertyChanged("profesorNombre");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=8)]
        public string iDClase {
            get {
                return this.iDClaseField;
            }
            set {
                this.iDClaseField = value;
                this.RaisePropertyChanged("iDClase");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=9)]
        public string iDCurso {
            get {
                return this.iDCursoField;
            }
            set {
                this.iDCursoField = value;
                this.RaisePropertyChanged("iDCurso");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://Services.upcnet.upc.com/")]
    public partial class cursoClase : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string diaField;
        
        private string horaFinField;
        
        private string horaIniField;
        
        private string idClaseField;
        
        private string idCursoField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string dia {
            get {
                return this.diaField;
            }
            set {
                this.diaField = value;
                this.RaisePropertyChanged("dia");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string horaFin {
            get {
                return this.horaFinField;
            }
            set {
                this.horaFinField = value;
                this.RaisePropertyChanged("horaFin");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string horaIni {
            get {
                return this.horaIniField;
            }
            set {
                this.horaIniField = value;
                this.RaisePropertyChanged("horaIni");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string idClase {
            get {
                return this.idClaseField;
            }
            set {
                this.idClaseField = value;
                this.RaisePropertyChanged("idClase");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public string idCurso {
            get {
                return this.idCursoField;
            }
            set {
                this.idCursoField = value;
                this.RaisePropertyChanged("idCurso");
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
    [System.ServiceModel.MessageContractAttribute(WrapperName="getCursoClases", WrapperNamespace="http://Services.upcnet.upc.com/", IsWrapped=true)]
    public partial class getCursoClasesRequest {
        
        public getCursoClasesRequest() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getCursoClasesResponse", WrapperNamespace="http://Services.upcnet.upc.com/", IsWrapped=true)]
    public partial class getCursoClasesResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://Services.upcnet.upc.com/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public UPCNETSystemCliente.UPCNETServiceCursoClase.cursoClaseReporte[] @return;
        
        public getCursoClasesResponse() {
        }
        
        public getCursoClasesResponse(UPCNETSystemCliente.UPCNETServiceCursoClase.cursoClaseReporte[] @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="setCursoClase", WrapperNamespace="http://Services.upcnet.upc.com/", IsWrapped=true)]
    public partial class setCursoClaseRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://Services.upcnet.upc.com/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public UPCNETSystemCliente.UPCNETServiceCursoClase.cursoClase arg0;
        
        public setCursoClaseRequest() {
        }
        
        public setCursoClaseRequest(UPCNETSystemCliente.UPCNETServiceCursoClase.cursoClase arg0) {
            this.arg0 = arg0;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="setCursoClaseResponse", WrapperNamespace="http://Services.upcnet.upc.com/", IsWrapped=true)]
    public partial class setCursoClaseResponse {
        
        public setCursoClaseResponse() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getCursoClaseById", WrapperNamespace="http://Services.upcnet.upc.com/", IsWrapped=true)]
    public partial class getCursoClaseByIdRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://Services.upcnet.upc.com/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string idClase;
        
        public getCursoClaseByIdRequest() {
        }
        
        public getCursoClaseByIdRequest(string idClase) {
            this.idClase = idClase;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getCursoClaseByIdResponse", WrapperNamespace="http://Services.upcnet.upc.com/", IsWrapped=true)]
    public partial class getCursoClaseByIdResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://Services.upcnet.upc.com/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public UPCNETSystemCliente.UPCNETServiceCursoClase.cursoClaseReporte @return;
        
        public getCursoClaseByIdResponse() {
        }
        
        public getCursoClaseByIdResponse(UPCNETSystemCliente.UPCNETServiceCursoClase.cursoClaseReporte @return) {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface UPCNETServiceCursoClaseChannel : UPCNETSystemCliente.UPCNETServiceCursoClase.UPCNETServiceCursoClase, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class UPCNETServiceCursoClaseClient : System.ServiceModel.ClientBase<UPCNETSystemCliente.UPCNETServiceCursoClase.UPCNETServiceCursoClase>, UPCNETSystemCliente.UPCNETServiceCursoClase.UPCNETServiceCursoClase {
        
        public UPCNETServiceCursoClaseClient() {
        }
        
        public UPCNETServiceCursoClaseClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public UPCNETServiceCursoClaseClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UPCNETServiceCursoClaseClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UPCNETServiceCursoClaseClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        UPCNETSystemCliente.UPCNETServiceCursoClase.helloResponse UPCNETSystemCliente.UPCNETServiceCursoClase.UPCNETServiceCursoClase.hello(UPCNETSystemCliente.UPCNETServiceCursoClase.helloRequest request) {
            return base.Channel.hello(request);
        }
        
        public string hello(string name) {
            UPCNETSystemCliente.UPCNETServiceCursoClase.helloRequest inValue = new UPCNETSystemCliente.UPCNETServiceCursoClase.helloRequest();
            inValue.name = name;
            UPCNETSystemCliente.UPCNETServiceCursoClase.helloResponse retVal = ((UPCNETSystemCliente.UPCNETServiceCursoClase.UPCNETServiceCursoClase)(this)).hello(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<UPCNETSystemCliente.UPCNETServiceCursoClase.helloResponse> UPCNETSystemCliente.UPCNETServiceCursoClase.UPCNETServiceCursoClase.helloAsync(UPCNETSystemCliente.UPCNETServiceCursoClase.helloRequest request) {
            return base.Channel.helloAsync(request);
        }
        
        public System.Threading.Tasks.Task<UPCNETSystemCliente.UPCNETServiceCursoClase.helloResponse> helloAsync(string name) {
            UPCNETSystemCliente.UPCNETServiceCursoClase.helloRequest inValue = new UPCNETSystemCliente.UPCNETServiceCursoClase.helloRequest();
            inValue.name = name;
            return ((UPCNETSystemCliente.UPCNETServiceCursoClase.UPCNETServiceCursoClase)(this)).helloAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        UPCNETSystemCliente.UPCNETServiceCursoClase.getCursoClasesResponse UPCNETSystemCliente.UPCNETServiceCursoClase.UPCNETServiceCursoClase.getCursoClases(UPCNETSystemCliente.UPCNETServiceCursoClase.getCursoClasesRequest request) {
            return base.Channel.getCursoClases(request);
        }
        
        public UPCNETSystemCliente.UPCNETServiceCursoClase.cursoClaseReporte[] getCursoClases() {
            UPCNETSystemCliente.UPCNETServiceCursoClase.getCursoClasesRequest inValue = new UPCNETSystemCliente.UPCNETServiceCursoClase.getCursoClasesRequest();
            UPCNETSystemCliente.UPCNETServiceCursoClase.getCursoClasesResponse retVal = ((UPCNETSystemCliente.UPCNETServiceCursoClase.UPCNETServiceCursoClase)(this)).getCursoClases(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<UPCNETSystemCliente.UPCNETServiceCursoClase.getCursoClasesResponse> UPCNETSystemCliente.UPCNETServiceCursoClase.UPCNETServiceCursoClase.getCursoClasesAsync(UPCNETSystemCliente.UPCNETServiceCursoClase.getCursoClasesRequest request) {
            return base.Channel.getCursoClasesAsync(request);
        }
        
        public System.Threading.Tasks.Task<UPCNETSystemCliente.UPCNETServiceCursoClase.getCursoClasesResponse> getCursoClasesAsync() {
            UPCNETSystemCliente.UPCNETServiceCursoClase.getCursoClasesRequest inValue = new UPCNETSystemCliente.UPCNETServiceCursoClase.getCursoClasesRequest();
            return ((UPCNETSystemCliente.UPCNETServiceCursoClase.UPCNETServiceCursoClase)(this)).getCursoClasesAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        UPCNETSystemCliente.UPCNETServiceCursoClase.setCursoClaseResponse UPCNETSystemCliente.UPCNETServiceCursoClase.UPCNETServiceCursoClase.setCursoClase(UPCNETSystemCliente.UPCNETServiceCursoClase.setCursoClaseRequest request) {
            return base.Channel.setCursoClase(request);
        }
        
        public void setCursoClase(UPCNETSystemCliente.UPCNETServiceCursoClase.cursoClase arg0) {
            UPCNETSystemCliente.UPCNETServiceCursoClase.setCursoClaseRequest inValue = new UPCNETSystemCliente.UPCNETServiceCursoClase.setCursoClaseRequest();
            inValue.arg0 = arg0;
            UPCNETSystemCliente.UPCNETServiceCursoClase.setCursoClaseResponse retVal = ((UPCNETSystemCliente.UPCNETServiceCursoClase.UPCNETServiceCursoClase)(this)).setCursoClase(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<UPCNETSystemCliente.UPCNETServiceCursoClase.setCursoClaseResponse> UPCNETSystemCliente.UPCNETServiceCursoClase.UPCNETServiceCursoClase.setCursoClaseAsync(UPCNETSystemCliente.UPCNETServiceCursoClase.setCursoClaseRequest request) {
            return base.Channel.setCursoClaseAsync(request);
        }
        
        public System.Threading.Tasks.Task<UPCNETSystemCliente.UPCNETServiceCursoClase.setCursoClaseResponse> setCursoClaseAsync(UPCNETSystemCliente.UPCNETServiceCursoClase.cursoClase arg0) {
            UPCNETSystemCliente.UPCNETServiceCursoClase.setCursoClaseRequest inValue = new UPCNETSystemCliente.UPCNETServiceCursoClase.setCursoClaseRequest();
            inValue.arg0 = arg0;
            return ((UPCNETSystemCliente.UPCNETServiceCursoClase.UPCNETServiceCursoClase)(this)).setCursoClaseAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        UPCNETSystemCliente.UPCNETServiceCursoClase.getCursoClaseByIdResponse UPCNETSystemCliente.UPCNETServiceCursoClase.UPCNETServiceCursoClase.getCursoClaseById(UPCNETSystemCliente.UPCNETServiceCursoClase.getCursoClaseByIdRequest request) {
            return base.Channel.getCursoClaseById(request);
        }
        
        public UPCNETSystemCliente.UPCNETServiceCursoClase.cursoClaseReporte getCursoClaseById(string idClase) {
            UPCNETSystemCliente.UPCNETServiceCursoClase.getCursoClaseByIdRequest inValue = new UPCNETSystemCliente.UPCNETServiceCursoClase.getCursoClaseByIdRequest();
            inValue.idClase = idClase;
            UPCNETSystemCliente.UPCNETServiceCursoClase.getCursoClaseByIdResponse retVal = ((UPCNETSystemCliente.UPCNETServiceCursoClase.UPCNETServiceCursoClase)(this)).getCursoClaseById(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<UPCNETSystemCliente.UPCNETServiceCursoClase.getCursoClaseByIdResponse> UPCNETSystemCliente.UPCNETServiceCursoClase.UPCNETServiceCursoClase.getCursoClaseByIdAsync(UPCNETSystemCliente.UPCNETServiceCursoClase.getCursoClaseByIdRequest request) {
            return base.Channel.getCursoClaseByIdAsync(request);
        }
        
        public System.Threading.Tasks.Task<UPCNETSystemCliente.UPCNETServiceCursoClase.getCursoClaseByIdResponse> getCursoClaseByIdAsync(string idClase) {
            UPCNETSystemCliente.UPCNETServiceCursoClase.getCursoClaseByIdRequest inValue = new UPCNETSystemCliente.UPCNETServiceCursoClase.getCursoClaseByIdRequest();
            inValue.idClase = idClase;
            return ((UPCNETSystemCliente.UPCNETServiceCursoClase.UPCNETServiceCursoClase)(this)).getCursoClaseByIdAsync(inValue);
        }
    }
}