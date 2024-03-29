﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DemoServiceReference
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="DemoServiceReference.IDemoService")]
    public interface IDemoService
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDemoService/Hello", ReplyAction="http://tempuri.org/IDemoService/HelloResponse")]
        System.Threading.Tasks.Task<string> HelloAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDemoService/Hi", ReplyAction="http://tempuri.org/IDemoService/HiResponse")]
        System.Threading.Tasks.Task<string> HiAsync(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDemoService/Sum", ReplyAction="http://tempuri.org/IDemoService/SumResponse")]
        System.Threading.Tasks.Task<int> SumAsync(int a, int b);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public interface IDemoServiceChannel : DemoServiceReference.IDemoService, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public partial class DemoServiceClient : System.ServiceModel.ClientBase<DemoServiceReference.IDemoService>, DemoServiceReference.IDemoService
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public DemoServiceClient() : 
                base(DemoServiceClient.GetDefaultBinding(), DemoServiceClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_IDemoService.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public DemoServiceClient(EndpointConfiguration endpointConfiguration) : 
                base(DemoServiceClient.GetBindingForEndpoint(endpointConfiguration), DemoServiceClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public DemoServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(DemoServiceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public DemoServiceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(DemoServiceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public DemoServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task<string> HelloAsync()
        {
            return base.Channel.HelloAsync();
        }
        
        public System.Threading.Tasks.Task<string> HiAsync(string name)
        {
            return base.Channel.HiAsync(name);
        }
        
        public System.Threading.Tasks.Task<int> SumAsync(int a, int b)
        {
            return base.Channel.SumAsync(a, b);
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
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IDemoService))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IDemoService))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:59029/DemoService.svc");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return DemoServiceClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_IDemoService);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return DemoServiceClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_IDemoService);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_IDemoService,
        }
    }
}
