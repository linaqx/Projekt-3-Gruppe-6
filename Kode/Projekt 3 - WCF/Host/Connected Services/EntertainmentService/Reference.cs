﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Host.EntertainmentService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Entertainment", Namespace="http://schemas.datacontract.org/2004/07/Projekt_3___WCF.Model")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(Host.EntertainmentService.Movie))]
    public partial class Entertainment : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Movie", Namespace="http://schemas.datacontract.org/2004/07/Projekt_3___WCF.Model")]
    [System.SerializableAttribute()]
    public partial class Movie : Host.EntertainmentService.Entertainment {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string genreField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string genre {
            get {
                return this.genreField;
            }
            set {
                if ((object.ReferenceEquals(this.genreField, value) != true)) {
                    this.genreField = value;
                    this.RaisePropertyChanged("genre");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Genre", Namespace="http://schemas.datacontract.org/2004/07/Model___Layer.Model")]
    [System.SerializableAttribute()]
    public partial class Genre : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="FilmingLocation", Namespace="http://schemas.datacontract.org/2004/07/Model___Layer.Model")]
    [System.SerializableAttribute()]
    public partial class FilmingLocation : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Language", Namespace="http://schemas.datacontract.org/2004/07/Model___Layer.Model")]
    [System.SerializableAttribute()]
    public partial class Language : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Country", Namespace="http://schemas.datacontract.org/2004/07/Model___Layer.Model")]
    [System.SerializableAttribute()]
    public partial class Country : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="EntertainmentService.IEntertainmentService")]
    public interface IEntertainmentService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEntertainmentService/FindAllEntertainments", ReplyAction="http://tempuri.org/IEntertainmentService/FindAllEntertainmentsResponse")]
        Host.EntertainmentService.Entertainment[] FindAllEntertainments();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEntertainmentService/FindAllEntertainments", ReplyAction="http://tempuri.org/IEntertainmentService/FindAllEntertainmentsResponse")]
        System.Threading.Tasks.Task<Host.EntertainmentService.Entertainment[]> FindAllEntertainmentsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEntertainmentService/FindPersonalEntertainments", ReplyAction="http://tempuri.org/IEntertainmentService/FindPersonalEntertainmentsResponse")]
        Host.EntertainmentService.Entertainment[] FindPersonalEntertainments(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEntertainmentService/FindPersonalEntertainments", ReplyAction="http://tempuri.org/IEntertainmentService/FindPersonalEntertainmentsResponse")]
        System.Threading.Tasks.Task<Host.EntertainmentService.Entertainment[]> FindPersonalEntertainmentsAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEntertainmentService/FindAllGenre", ReplyAction="http://tempuri.org/IEntertainmentService/FindAllGenreResponse")]
        Host.EntertainmentService.Genre[] FindAllGenre();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEntertainmentService/FindAllGenre", ReplyAction="http://tempuri.org/IEntertainmentService/FindAllGenreResponse")]
        System.Threading.Tasks.Task<Host.EntertainmentService.Genre[]> FindAllGenreAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEntertainmentService/FindAllFilmingLocations", ReplyAction="http://tempuri.org/IEntertainmentService/FindAllFilmingLocationsResponse")]
        Host.EntertainmentService.FilmingLocation[] FindAllFilmingLocations();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEntertainmentService/FindAllFilmingLocations", ReplyAction="http://tempuri.org/IEntertainmentService/FindAllFilmingLocationsResponse")]
        System.Threading.Tasks.Task<Host.EntertainmentService.FilmingLocation[]> FindAllFilmingLocationsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEntertainmentService/FindAllLanguage", ReplyAction="http://tempuri.org/IEntertainmentService/FindAllLanguageResponse")]
        Host.EntertainmentService.Language[] FindAllLanguage();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEntertainmentService/FindAllLanguage", ReplyAction="http://tempuri.org/IEntertainmentService/FindAllLanguageResponse")]
        System.Threading.Tasks.Task<Host.EntertainmentService.Language[]> FindAllLanguageAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEntertainmentService/FindAllCountries", ReplyAction="http://tempuri.org/IEntertainmentService/FindAllCountriesResponse")]
        Host.EntertainmentService.Country[] FindAllCountries();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEntertainmentService/FindAllCountries", ReplyAction="http://tempuri.org/IEntertainmentService/FindAllCountriesResponse")]
        System.Threading.Tasks.Task<Host.EntertainmentService.Country[]> FindAllCountriesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEntertainmentService/StartInsertMovieTransaction", ReplyAction="http://tempuri.org/IEntertainmentService/StartInsertMovieTransactionResponse")]
        void StartInsertMovieTransaction(Host.EntertainmentService.Movie m);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEntertainmentService/StartInsertMovieTransaction", ReplyAction="http://tempuri.org/IEntertainmentService/StartInsertMovieTransactionResponse")]
        System.Threading.Tasks.Task StartInsertMovieTransactionAsync(Host.EntertainmentService.Movie m);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IEntertainmentServiceChannel : Host.EntertainmentService.IEntertainmentService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class EntertainmentServiceClient : System.ServiceModel.ClientBase<Host.EntertainmentService.IEntertainmentService>, Host.EntertainmentService.IEntertainmentService {
        
        public EntertainmentServiceClient() {
        }
        
        public EntertainmentServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public EntertainmentServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EntertainmentServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EntertainmentServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Host.EntertainmentService.Entertainment[] FindAllEntertainments() {
            return base.Channel.FindAllEntertainments();
        }
        
        public System.Threading.Tasks.Task<Host.EntertainmentService.Entertainment[]> FindAllEntertainmentsAsync() {
            return base.Channel.FindAllEntertainmentsAsync();
        }
        
        public Host.EntertainmentService.Entertainment[] FindPersonalEntertainments(int id) {
            return base.Channel.FindPersonalEntertainments(id);
        }
        
        public System.Threading.Tasks.Task<Host.EntertainmentService.Entertainment[]> FindPersonalEntertainmentsAsync(int id) {
            return base.Channel.FindPersonalEntertainmentsAsync(id);
        }
        
        public Host.EntertainmentService.Genre[] FindAllGenre() {
            return base.Channel.FindAllGenre();
        }
        
        public System.Threading.Tasks.Task<Host.EntertainmentService.Genre[]> FindAllGenreAsync() {
            return base.Channel.FindAllGenreAsync();
        }
        
        public Host.EntertainmentService.FilmingLocation[] FindAllFilmingLocations() {
            return base.Channel.FindAllFilmingLocations();
        }
        
        public System.Threading.Tasks.Task<Host.EntertainmentService.FilmingLocation[]> FindAllFilmingLocationsAsync() {
            return base.Channel.FindAllFilmingLocationsAsync();
        }
        
        public Host.EntertainmentService.Language[] FindAllLanguage() {
            return base.Channel.FindAllLanguage();
        }
        
        public System.Threading.Tasks.Task<Host.EntertainmentService.Language[]> FindAllLanguageAsync() {
            return base.Channel.FindAllLanguageAsync();
        }
        
        public Host.EntertainmentService.Country[] FindAllCountries() {
            return base.Channel.FindAllCountries();
        }
        
        public System.Threading.Tasks.Task<Host.EntertainmentService.Country[]> FindAllCountriesAsync() {
            return base.Channel.FindAllCountriesAsync();
        }
        
        public void StartInsertMovieTransaction(Host.EntertainmentService.Movie m) {
            base.Channel.StartInsertMovieTransaction(m);
        }
        
        public System.Threading.Tasks.Task StartInsertMovieTransactionAsync(Host.EntertainmentService.Movie m) {
            return base.Channel.StartInsertMovieTransactionAsync(m);
        }
    }
}
