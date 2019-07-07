﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     //
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebService
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://ServicesPackage", ConfigurationName="WebService.ServicesPortType")]
    public interface ServicesPortType
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:getBalances", ReplyAction="urn:getBalancesResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<WebService.getBalancesResponse> getBalancesAsync(WebService.getBalancesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:createAccount", ReplyAction="urn:createAccountResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<WebService.createAccountResponse> createAccountAsync(WebService.createAccountRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:login", ReplyAction="urn:loginResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<WebService.loginResponse> loginAsync(WebService.loginRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:changePassword", ReplyAction="urn:changePasswordResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<WebService.changePasswordResponse> changePasswordAsync(WebService.changePasswordRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getBalances", WrapperNamespace="http://ServicesPackage", IsWrapped=true)]
    public partial class getBalancesRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ServicesPackage", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string inputPhoneNumber;
        
        public getBalancesRequest()
        {
        }
        
        public getBalancesRequest(string inputPhoneNumber)
        {
            this.inputPhoneNumber = inputPhoneNumber;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getBalancesResponse", WrapperNamespace="http://ServicesPackage", IsWrapped=true)]
    public partial class getBalancesResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ServicesPackage", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("return")]
        public int[] @return;
        
        public getBalancesResponse()
        {
        }
        
        public getBalancesResponse(int[] @return)
        {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="createAccount", WrapperNamespace="http://ServicesPackage", IsWrapped=true)]
    public partial class createAccountRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ServicesPackage", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string inputFirstName;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ServicesPackage", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string inputLastName;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ServicesPackage", Order=2)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string inputPhoneNumber;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ServicesPackage", Order=3)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string inputEmail;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ServicesPackage", Order=4)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string inputPassword;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ServicesPackage", Order=5)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string inputBirthDate;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ServicesPackage", Order=6)]
        public double inputTcNumber;
        
        public createAccountRequest()
        {
        }
        
        public createAccountRequest(string inputFirstName, string inputLastName, string inputPhoneNumber, string inputEmail, string inputPassword, string inputBirthDate, double inputTcNumber)
        {
            this.inputFirstName = inputFirstName;
            this.inputLastName = inputLastName;
            this.inputPhoneNumber = inputPhoneNumber;
            this.inputEmail = inputEmail;
            this.inputPassword = inputPassword;
            this.inputBirthDate = inputBirthDate;
            this.inputTcNumber = inputTcNumber;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="createAccountResponse", WrapperNamespace="http://ServicesPackage", IsWrapped=true)]
    public partial class createAccountResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ServicesPackage", Order=0)]
        public int @return;
        
        public createAccountResponse()
        {
        }
        
        public createAccountResponse(int @return)
        {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="login", WrapperNamespace="http://ServicesPackage", IsWrapped=true)]
    public partial class loginRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ServicesPackage", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string inputPhoneNumber;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ServicesPackage", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string inputPassword;
        
        public loginRequest()
        {
        }
        
        public loginRequest(string inputPhoneNumber, string inputPassword)
        {
            this.inputPhoneNumber = inputPhoneNumber;
            this.inputPassword = inputPassword;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="loginResponse", WrapperNamespace="http://ServicesPackage", IsWrapped=true)]
    public partial class loginResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ServicesPackage", Order=0)]
        public int @return;
        
        public loginResponse()
        {
        }
        
        public loginResponse(int @return)
        {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="changePassword", WrapperNamespace="http://ServicesPackage", IsWrapped=true)]
    public partial class changePasswordRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ServicesPackage", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string inputPhoneNumber;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ServicesPackage", Order=1)]
        public double inputTcNumber;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ServicesPackage", Order=2)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string inputNewPassword;
        
        public changePasswordRequest()
        {
        }
        
        public changePasswordRequest(string inputPhoneNumber, double inputTcNumber, string inputNewPassword)
        {
            this.inputPhoneNumber = inputPhoneNumber;
            this.inputTcNumber = inputTcNumber;
            this.inputNewPassword = inputNewPassword;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="changePasswordResponse", WrapperNamespace="http://ServicesPackage", IsWrapped=true)]
    public partial class changePasswordResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ServicesPackage", Order=0)]
        public int @return;
        
        public changePasswordResponse()
        {
        }
        
        public changePasswordResponse(int @return)
        {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    public interface ServicesPortTypeChannel : WebService.ServicesPortType, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    public partial class ServicesPortTypeClient : System.ServiceModel.ClientBase<WebService.ServicesPortType>, WebService.ServicesPortType
    {
        
    /// <summary>
    /// Implement this partial method to configure the service endpoint.
    /// </summary>
    /// <param name="serviceEndpoint">The endpoint to configure</param>
    /// <param name="clientCredentials">The client credentials</param>
    static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public ServicesPortTypeClient(EndpointConfiguration endpointConfiguration) : 
                base(ServicesPortTypeClient.GetBindingForEndpoint(endpointConfiguration), ServicesPortTypeClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ServicesPortTypeClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(ServicesPortTypeClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ServicesPortTypeClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(ServicesPortTypeClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ServicesPortTypeClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WebService.getBalancesResponse> WebService.ServicesPortType.getBalancesAsync(WebService.getBalancesRequest request)
        {
            return base.Channel.getBalancesAsync(request);
        }
        
        public System.Threading.Tasks.Task<WebService.getBalancesResponse> getBalancesAsync(string inputPhoneNumber)
        {
            WebService.getBalancesRequest inValue = new WebService.getBalancesRequest();
            inValue.inputPhoneNumber = inputPhoneNumber;
            return ((WebService.ServicesPortType)(this)).getBalancesAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WebService.createAccountResponse> WebService.ServicesPortType.createAccountAsync(WebService.createAccountRequest request)
        {
            return base.Channel.createAccountAsync(request);
        }
        
        public System.Threading.Tasks.Task<WebService.createAccountResponse> createAccountAsync(string inputFirstName, string inputLastName, string inputPhoneNumber, string inputEmail, string inputPassword, string inputBirthDate, double inputTcNumber)
        {
            WebService.createAccountRequest inValue = new WebService.createAccountRequest();
            inValue.inputFirstName = inputFirstName;
            inValue.inputLastName = inputLastName;
            inValue.inputPhoneNumber = inputPhoneNumber;
            inValue.inputEmail = inputEmail;
            inValue.inputPassword = inputPassword;
            inValue.inputBirthDate = inputBirthDate;
            inValue.inputTcNumber = inputTcNumber;
            return ((WebService.ServicesPortType)(this)).createAccountAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WebService.loginResponse> WebService.ServicesPortType.loginAsync(WebService.loginRequest request)
        {
            return base.Channel.loginAsync(request);
        }
        
        public System.Threading.Tasks.Task<WebService.loginResponse> loginAsync(string inputPhoneNumber, string inputPassword)
        {
            WebService.loginRequest inValue = new WebService.loginRequest();
            inValue.inputPhoneNumber = inputPhoneNumber;
            inValue.inputPassword = inputPassword;
            return ((WebService.ServicesPortType)(this)).loginAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WebService.changePasswordResponse> WebService.ServicesPortType.changePasswordAsync(WebService.changePasswordRequest request)
        {
            return base.Channel.changePasswordAsync(request);
        }
        
        public System.Threading.Tasks.Task<WebService.changePasswordResponse> changePasswordAsync(string inputPhoneNumber, double inputTcNumber, string inputNewPassword)
        {
            WebService.changePasswordRequest inValue = new WebService.changePasswordRequest();
            inValue.inputPhoneNumber = inputPhoneNumber;
            inValue.inputTcNumber = inputTcNumber;
            inValue.inputNewPassword = inputNewPassword;
            return ((WebService.ServicesPortType)(this)).changePasswordAsync(inValue);
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
            if ((endpointConfiguration == EndpointConfiguration.ServicesHttpSoap11Endpoint))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            if ((endpointConfiguration == EndpointConfiguration.ServicesHttpSoap12Endpoint))
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
            if ((endpointConfiguration == EndpointConfiguration.ServicesHttpSoap11Endpoint))
            {
                return new System.ServiceModel.EndpointAddress("http://68.183.75.84:8080/i2iCellService/services/Services.ServicesHttpSoap11Endpo" +
                        "int/");
            }
            if ((endpointConfiguration == EndpointConfiguration.ServicesHttpSoap12Endpoint))
            {
                return new System.ServiceModel.EndpointAddress("http://68.183.75.84:8080/i2iCellService/services/Services.ServicesHttpSoap12Endpo" +
                        "int/");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        public enum EndpointConfiguration
        {
            
            ServicesHttpSoap11Endpoint,
            
            ServicesHttpSoap12Endpoint,
        }
    }
}