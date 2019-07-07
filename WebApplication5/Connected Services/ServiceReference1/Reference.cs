﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     //
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceReference1
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://CalculatorDemo", ConfigurationName="ServiceReference1.DBConnectionPortType")]
    public interface DBConnectionPortType
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:callLoginProcedure", ReplyAction="urn:callLoginProcedureResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<ServiceReference1.callLoginProcedureResponse> callLoginProcedureAsync(ServiceReference1.callLoginProcedureRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:callCreateProcedure", ReplyAction="urn:callCreateProcedureResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<ServiceReference1.callCreateProcedureResponse> callCreateProcedureAsync(ServiceReference1.callCreateProcedureRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="callLoginProcedure", WrapperNamespace="http://CalculatorDemo", IsWrapped=true)]
    public partial class callLoginProcedureRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://CalculatorDemo", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string inputPhoneNumber;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://CalculatorDemo", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string inputPassword;
        
        public callLoginProcedureRequest()
        {
        }
        
        public callLoginProcedureRequest(string inputPhoneNumber, string inputPassword)
        {
            this.inputPhoneNumber = inputPhoneNumber;
            this.inputPassword = inputPassword;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="callLoginProcedureResponse", WrapperNamespace="http://CalculatorDemo", IsWrapped=true)]
    public partial class callLoginProcedureResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://CalculatorDemo", Order=0)]
        public int @return;
        
        public callLoginProcedureResponse()
        {
        }
        
        public callLoginProcedureResponse(int @return)
        {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="callCreateProcedure", WrapperNamespace="http://CalculatorDemo", IsWrapped=true)]
    public partial class callCreateProcedureRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://CalculatorDemo", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string inputFirstName;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://CalculatorDemo", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string inputLastName;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://CalculatorDemo", Order=2)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string inputPhoneNumber;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://CalculatorDemo", Order=3)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string inputEmail;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://CalculatorDemo", Order=4)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string inputPassword;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://CalculatorDemo", Order=5)]
        [System.Xml.Serialization.XmlElementAttribute(DataType="date", IsNullable=true)]
        public System.Nullable<System.DateTime> inputBirthdayDate;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://CalculatorDemo", Order=6)]
        public double inputTcNumber;
        
        public callCreateProcedureRequest()
        {
        }
        
        public callCreateProcedureRequest(string inputFirstName, string inputLastName, string inputPhoneNumber, string inputEmail, string inputPassword, System.Nullable<System.DateTime> inputBirthdayDate, double inputTcNumber)
        {
            this.inputFirstName = inputFirstName;
            this.inputLastName = inputLastName;
            this.inputPhoneNumber = inputPhoneNumber;
            this.inputEmail = inputEmail;
            this.inputPassword = inputPassword;
            this.inputBirthdayDate = inputBirthdayDate;
            this.inputTcNumber = inputTcNumber;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="callCreateProcedureResponse", WrapperNamespace="http://CalculatorDemo", IsWrapped=true)]
    public partial class callCreateProcedureResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://CalculatorDemo", Order=0)]
        public int @return;
        
        public callCreateProcedureResponse()
        {
        }
        
        public callCreateProcedureResponse(int @return)
        {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    public interface DBConnectionPortTypeChannel : ServiceReference1.DBConnectionPortType, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    public partial class DBConnectionPortTypeClient : System.ServiceModel.ClientBase<ServiceReference1.DBConnectionPortType>, ServiceReference1.DBConnectionPortType
    {
        
    /// <summary>
    /// Implement this partial method to configure the service endpoint.
    /// </summary>
    /// <param name="serviceEndpoint">The endpoint to configure</param>
    /// <param name="clientCredentials">The client credentials</param>
    static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public DBConnectionPortTypeClient(EndpointConfiguration endpointConfiguration) : 
                base(DBConnectionPortTypeClient.GetBindingForEndpoint(endpointConfiguration), DBConnectionPortTypeClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public DBConnectionPortTypeClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(DBConnectionPortTypeClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public DBConnectionPortTypeClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(DBConnectionPortTypeClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public DBConnectionPortTypeClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReference1.callLoginProcedureResponse> ServiceReference1.DBConnectionPortType.callLoginProcedureAsync(ServiceReference1.callLoginProcedureRequest request)
        {
            return base.Channel.callLoginProcedureAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.callLoginProcedureResponse> callLoginProcedureAsync(string inputPhoneNumber, string inputPassword)
        {
            ServiceReference1.callLoginProcedureRequest inValue = new ServiceReference1.callLoginProcedureRequest();
            inValue.inputPhoneNumber = inputPhoneNumber;
            inValue.inputPassword = inputPassword;
            return ((ServiceReference1.DBConnectionPortType)(this)).callLoginProcedureAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReference1.callCreateProcedureResponse> ServiceReference1.DBConnectionPortType.callCreateProcedureAsync(ServiceReference1.callCreateProcedureRequest request)
        {
            return base.Channel.callCreateProcedureAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.callCreateProcedureResponse> callCreateProcedureAsync(string inputFirstName, string inputLastName, string inputPhoneNumber, string inputEmail, string inputPassword, System.Nullable<System.DateTime> inputBirthdayDate, double inputTcNumber)
        {
            ServiceReference1.callCreateProcedureRequest inValue = new ServiceReference1.callCreateProcedureRequest();
            inValue.inputFirstName = inputFirstName;
            inValue.inputLastName = inputLastName;
            inValue.inputPhoneNumber = inputPhoneNumber;
            inValue.inputEmail = inputEmail;
            inValue.inputPassword = inputPassword;
            inValue.inputBirthdayDate = inputBirthdayDate;
            inValue.inputTcNumber = inputTcNumber;
            return ((ServiceReference1.DBConnectionPortType)(this)).callCreateProcedureAsync(inValue);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.DBConnectionHttpSoap11Endpoint))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            if ((endpointConfiguration == EndpointConfiguration.DBConnectionHttpSoap12Endpoint))
            {
                System.ServiceModel.Channels.CustomBinding result = new System.ServiceModel.Channels.CustomBinding();
                System.ServiceModel.Channels.TextMessageEncodingBindingElement textBindingElement = new System.ServiceModel.Channels.TextMessageEncodingBindingElement();
                textBindingElement.MessageVersion = System.ServiceModel.Channels.MessageVersion.CreateVersion(System.ServiceModel.EnvelopeVersion.Soap12, System.ServiceModel.Channels.AddressingVersion.None);
                result.Elements.Add(textBindingElement);
                System.ServiceModel.Channels.HttpTransportBindingElement httpBindingElement = new System.ServiceModel.Channels.HttpTransportBindingElement();
                httpBindingElement.AllowCookies = true;
                httpBindingElement.MaxBufferSize = int.MaxValue;
                httpBindingElement.MaxReceivedMessageSize = int.MaxValue;
                result.Elements.Add(httpBindingElement);
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.DBConnectionHttpSoap11Endpoint))
            {
                return new System.ServiceModel.EndpointAddress("http://68.183.75.84:8080/Calculator/services/DBConnection.DBConnectionHttpSoap11E" +
                        "ndpoint/");
            }
            if ((endpointConfiguration == EndpointConfiguration.DBConnectionHttpSoap12Endpoint))
            {
                return new System.ServiceModel.EndpointAddress("http://68.183.75.84:8080/Calculator/services/DBConnection.DBConnectionHttpSoap12E" +
                        "ndpoint/");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        public enum EndpointConfiguration
        {
            
            DBConnectionHttpSoap11Endpoint,
            
            DBConnectionHttpSoap12Endpoint,
        }
    }
}
