﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UPCNETCliente.ServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://Services.upcnet.upc.com/", ConfigurationName="ServiceReference.UPCNETService")]
    public interface UPCNETService {
        
        // CODEGEN: Parameter 'return' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://Services.upcnet.upc.com/UPCNETService/Enviar_AlumnosRequest", ReplyAction="http://Services.upcnet.upc.com/UPCNETService/Enviar_AlumnosResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Enviar_Alumnos))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(helloResponse))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(hello))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        UPCNETCliente.ServiceReference.Enviar_AlumnosResponse Enviar_Alumnos(UPCNETCliente.ServiceReference.Enviar_AlumnosRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Services.upcnet.upc.com/UPCNETService/Enviar_AlumnosRequest", ReplyAction="http://Services.upcnet.upc.com/UPCNETService/Enviar_AlumnosResponse")]
        System.Threading.Tasks.Task<UPCNETCliente.ServiceReference.Enviar_AlumnosResponse> Enviar_AlumnosAsync(UPCNETCliente.ServiceReference.Enviar_AlumnosRequest request);
        
        // CODEGEN: Parameter 'return' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://Services.upcnet.upc.com/UPCNETService/helloRequest", ReplyAction="http://Services.upcnet.upc.com/UPCNETService/helloResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Enviar_Alumnos))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(helloResponse))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(hello))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        UPCNETCliente.ServiceReference.helloResponse1 hello(UPCNETCliente.ServiceReference.helloRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Services.upcnet.upc.com/UPCNETService/helloRequest", ReplyAction="http://Services.upcnet.upc.com/UPCNETService/helloResponse")]
        System.Threading.Tasks.Task<UPCNETCliente.ServiceReference.helloResponse1> helloAsync(UPCNETCliente.ServiceReference.helloRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://Services.upcnet.upc.com/")]
    public partial class alumno : object, System.ComponentModel.INotifyPropertyChanged {
        
        private object[] alumno1Field;
        
        private string apellidoField;
        
        private string carreraField;
        
        private string codigoField;
        
        private string correoField;
        
        private string dNIField;
        
        private string fechaField;
        
        private string iDCategoriaField;
        
        private string nombreField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("alumno", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true, Order=0)]
        public object[] alumno1 {
            get {
                return this.alumno1Field;
            }
            set {
                this.alumno1Field = value;
                this.RaisePropertyChanged("alumno1");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
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
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string carrera {
            get {
                return this.carreraField;
            }
            set {
                this.carreraField = value;
                this.RaisePropertyChanged("carrera");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string codigo {
            get {
                return this.codigoField;
            }
            set {
                this.codigoField = value;
                this.RaisePropertyChanged("codigo");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
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
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public string DNI {
            get {
                return this.dNIField;
            }
            set {
                this.dNIField = value;
                this.RaisePropertyChanged("DNI");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public string fecha {
            get {
                return this.fechaField;
            }
            set {
                this.fechaField = value;
                this.RaisePropertyChanged("fecha");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=7)]
        public string IDCategoria {
            get {
                return this.iDCategoriaField;
            }
            set {
                this.iDCategoriaField = value;
                this.RaisePropertyChanged("IDCategoria");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=8)]
        public string nombre {
            get {
                return this.nombreField;
            }
            set {
                this.nombreField = value;
                this.RaisePropertyChanged("nombre");
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
    public partial class Enviar_Alumnos : object, System.ComponentModel.INotifyPropertyChanged {
        
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
    public partial class helloResponse : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string returnField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string @return {
            get {
                return this.returnField;
            }
            set {
                this.returnField = value;
                this.RaisePropertyChanged("return");
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
    public partial class hello : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string nameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
                this.RaisePropertyChanged("name");
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
    [System.ServiceModel.MessageContractAttribute(WrapperName="Enviar_Alumnos", WrapperNamespace="http://Services.upcnet.upc.com/", IsWrapped=true)]
    public partial class Enviar_AlumnosRequest {
        
        public Enviar_AlumnosRequest() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Enviar_AlumnosResponse", WrapperNamespace="http://Services.upcnet.upc.com/", IsWrapped=true)]
    public partial class Enviar_AlumnosResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://Services.upcnet.upc.com/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public UPCNETCliente.ServiceReference.alumno[] @return;
        
        public Enviar_AlumnosResponse() {
        }
        
        public Enviar_AlumnosResponse(UPCNETCliente.ServiceReference.alumno[] @return) {
            this.@return = @return;
        }
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
    public partial class helloResponse1 {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://Services.upcnet.upc.com/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string @return;
        
        public helloResponse1() {
        }
        
        public helloResponse1(string @return) {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface UPCNETServiceChannel : UPCNETCliente.ServiceReference.UPCNETService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class UPCNETServiceClient : System.ServiceModel.ClientBase<UPCNETCliente.ServiceReference.UPCNETService>, UPCNETCliente.ServiceReference.UPCNETService {
        
        public UPCNETServiceClient() {
        }
        
        public UPCNETServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public UPCNETServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UPCNETServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UPCNETServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        UPCNETCliente.ServiceReference.Enviar_AlumnosResponse UPCNETCliente.ServiceReference.UPCNETService.Enviar_Alumnos(UPCNETCliente.ServiceReference.Enviar_AlumnosRequest request) {
            return base.Channel.Enviar_Alumnos(request);
        }
        
        public UPCNETCliente.ServiceReference.alumno[] Enviar_Alumnos() {
            UPCNETCliente.ServiceReference.Enviar_AlumnosRequest inValue = new UPCNETCliente.ServiceReference.Enviar_AlumnosRequest();
            UPCNETCliente.ServiceReference.Enviar_AlumnosResponse retVal = ((UPCNETCliente.ServiceReference.UPCNETService)(this)).Enviar_Alumnos(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<UPCNETCliente.ServiceReference.Enviar_AlumnosResponse> UPCNETCliente.ServiceReference.UPCNETService.Enviar_AlumnosAsync(UPCNETCliente.ServiceReference.Enviar_AlumnosRequest request) {
            return base.Channel.Enviar_AlumnosAsync(request);
        }
        
        public System.Threading.Tasks.Task<UPCNETCliente.ServiceReference.Enviar_AlumnosResponse> Enviar_AlumnosAsync() {
            UPCNETCliente.ServiceReference.Enviar_AlumnosRequest inValue = new UPCNETCliente.ServiceReference.Enviar_AlumnosRequest();
            return ((UPCNETCliente.ServiceReference.UPCNETService)(this)).Enviar_AlumnosAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        UPCNETCliente.ServiceReference.helloResponse1 UPCNETCliente.ServiceReference.UPCNETService.hello(UPCNETCliente.ServiceReference.helloRequest request) {
            return base.Channel.hello(request);
        }
        
        public string hello(string name) {
            UPCNETCliente.ServiceReference.helloRequest inValue = new UPCNETCliente.ServiceReference.helloRequest();
            inValue.name = name;
            UPCNETCliente.ServiceReference.helloResponse1 retVal = ((UPCNETCliente.ServiceReference.UPCNETService)(this)).hello(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<UPCNETCliente.ServiceReference.helloResponse1> UPCNETCliente.ServiceReference.UPCNETService.helloAsync(UPCNETCliente.ServiceReference.helloRequest request) {
            return base.Channel.helloAsync(request);
        }
        
        public System.Threading.Tasks.Task<UPCNETCliente.ServiceReference.helloResponse1> helloAsync(string name) {
            UPCNETCliente.ServiceReference.helloRequest inValue = new UPCNETCliente.ServiceReference.helloRequest();
            inValue.name = name;
            return ((UPCNETCliente.ServiceReference.UPCNETService)(this)).helloAsync(inValue);
        }
    }
}