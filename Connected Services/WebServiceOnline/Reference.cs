﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebServiceTerceroOnline.WebServiceOnline {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WebServiceOnline.CalculatorSoap")]
    public interface CalculatorSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Add", ReplyAction="*")]
        int Add(int intA, int intB);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Subtract", ReplyAction="*")]
        int Subtract(int intA, int intB);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Multiply", ReplyAction="*")]
        int Multiply(int intA, int intB);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Divide", ReplyAction="*")]
        int Divide(int intA, int intB);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface CalculatorSoapChannel : WebServiceTerceroOnline.WebServiceOnline.CalculatorSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CalculatorSoapClient : System.ServiceModel.ClientBase<WebServiceTerceroOnline.WebServiceOnline.CalculatorSoap>, WebServiceTerceroOnline.WebServiceOnline.CalculatorSoap {
        
        public CalculatorSoapClient() {
        }
        
        public CalculatorSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CalculatorSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalculatorSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalculatorSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int Add(int intA, int intB) {
            return base.Channel.Add(intA, intB);
        }
        
        public int Subtract(int intA, int intB) {
            return base.Channel.Subtract(intA, intB);
        }
        
        public int Multiply(int intA, int intB) {
            return base.Channel.Multiply(intA, intB);
        }
        
        public int Divide(int intA, int intB) {
            return base.Channel.Divide(intA, intB);
        }
    }
}