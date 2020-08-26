﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LD3_Web_App.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.StringWebServiceSoap")]
    public interface StringWebServiceSoap {
        
        // CODEGEN: Generating message contract since element name txt from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Edit", ReplyAction="*")]
        LD3_Web_App.ServiceReference1.EditResponse Edit(LD3_Web_App.ServiceReference1.EditRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Edit", ReplyAction="*")]
        System.Threading.Tasks.Task<LD3_Web_App.ServiceReference1.EditResponse> EditAsync(LD3_Web_App.ServiceReference1.EditRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class EditRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Edit", Namespace="http://tempuri.org/", Order=0)]
        public LD3_Web_App.ServiceReference1.EditRequestBody Body;
        
        public EditRequest() {
        }
        
        public EditRequest(LD3_Web_App.ServiceReference1.EditRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class EditRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string txt;
        
        public EditRequestBody() {
        }
        
        public EditRequestBody(string txt) {
            this.txt = txt;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class EditResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="EditResponse", Namespace="http://tempuri.org/", Order=0)]
        public LD3_Web_App.ServiceReference1.EditResponseBody Body;
        
        public EditResponse() {
        }
        
        public EditResponse(LD3_Web_App.ServiceReference1.EditResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class EditResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string EditResult;
        
        public EditResponseBody() {
        }
        
        public EditResponseBody(string EditResult) {
            this.EditResult = EditResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface StringWebServiceSoapChannel : LD3_Web_App.ServiceReference1.StringWebServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class StringWebServiceSoapClient : System.ServiceModel.ClientBase<LD3_Web_App.ServiceReference1.StringWebServiceSoap>, LD3_Web_App.ServiceReference1.StringWebServiceSoap {
        
        public StringWebServiceSoapClient() {
        }
        
        public StringWebServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public StringWebServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public StringWebServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public StringWebServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        LD3_Web_App.ServiceReference1.EditResponse LD3_Web_App.ServiceReference1.StringWebServiceSoap.Edit(LD3_Web_App.ServiceReference1.EditRequest request) {
            return base.Channel.Edit(request);
        }
        
        public string Edit(string txt) {
            LD3_Web_App.ServiceReference1.EditRequest inValue = new LD3_Web_App.ServiceReference1.EditRequest();
            inValue.Body = new LD3_Web_App.ServiceReference1.EditRequestBody();
            inValue.Body.txt = txt;
            LD3_Web_App.ServiceReference1.EditResponse retVal = ((LD3_Web_App.ServiceReference1.StringWebServiceSoap)(this)).Edit(inValue);
            return retVal.Body.EditResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<LD3_Web_App.ServiceReference1.EditResponse> LD3_Web_App.ServiceReference1.StringWebServiceSoap.EditAsync(LD3_Web_App.ServiceReference1.EditRequest request) {
            return base.Channel.EditAsync(request);
        }
        
        public System.Threading.Tasks.Task<LD3_Web_App.ServiceReference1.EditResponse> EditAsync(string txt) {
            LD3_Web_App.ServiceReference1.EditRequest inValue = new LD3_Web_App.ServiceReference1.EditRequest();
            inValue.Body = new LD3_Web_App.ServiceReference1.EditRequestBody();
            inValue.Body.txt = txt;
            return ((LD3_Web_App.ServiceReference1.StringWebServiceSoap)(this)).EditAsync(inValue);
        }
    }
}
