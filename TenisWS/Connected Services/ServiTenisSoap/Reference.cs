﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TenisWS.ServiTenisSoap {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="urn:index", ConfigurationName="ServiTenisSoap.indexPortType")]
    public interface indexPortType {
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:index#insertSnikear", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        string insertSnikear(string marca, string nombre, int precio, string color, string material);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:index#insertSnikear", ReplyAction="*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        System.Threading.Tasks.Task<string> insertSnikearAsync(string marca, string nombre, int precio, string color, string material);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:index#GetSnikear", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="data")]
        string GetSnikear(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:index#GetSnikear", ReplyAction="*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="data")]
        System.Threading.Tasks.Task<string> GetSnikearAsync(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:index#DelSnikear", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="data")]
        string DelSnikear(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:index#DelSnikear", ReplyAction="*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="data")]
        System.Threading.Tasks.Task<string> DelSnikearAsync(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:index#UpdaSnikear", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="data")]
        string UpdaSnikear(int id, string marca, string nombre, int precio, string color, string material);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:index#UpdaSnikear", ReplyAction="*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="data")]
        System.Threading.Tasks.Task<string> UpdaSnikearAsync(int id, string marca, string nombre, int precio, string color, string material);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface indexPortTypeChannel : TenisWS.ServiTenisSoap.indexPortType, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class indexPortTypeClient : System.ServiceModel.ClientBase<TenisWS.ServiTenisSoap.indexPortType>, TenisWS.ServiTenisSoap.indexPortType {
        
        public indexPortTypeClient() {
        }
        
        public indexPortTypeClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public indexPortTypeClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public indexPortTypeClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public indexPortTypeClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string insertSnikear(string marca, string nombre, int precio, string color, string material) {
            return base.Channel.insertSnikear(marca, nombre, precio, color, material);
        }
        
        public System.Threading.Tasks.Task<string> insertSnikearAsync(string marca, string nombre, int precio, string color, string material) {
            return base.Channel.insertSnikearAsync(marca, nombre, precio, color, material);
        }
        
        public string GetSnikear(string id) {
            return base.Channel.GetSnikear(id);
        }
        
        public System.Threading.Tasks.Task<string> GetSnikearAsync(string id) {
            return base.Channel.GetSnikearAsync(id);
        }
        
        public string DelSnikear(string id) {
            return base.Channel.DelSnikear(id);
        }
        
        public System.Threading.Tasks.Task<string> DelSnikearAsync(string id) {
            return base.Channel.DelSnikearAsync(id);
        }
        
        public string UpdaSnikear(int id, string marca, string nombre, int precio, string color, string material) {
            return base.Channel.UpdaSnikear(id, marca, nombre, precio, color, material);
        }
        
        public System.Threading.Tasks.Task<string> UpdaSnikearAsync(int id, string marca, string nombre, int precio, string color, string material) {
            return base.Channel.UpdaSnikearAsync(id, marca, nombre, precio, color, material);
        }
    }
}