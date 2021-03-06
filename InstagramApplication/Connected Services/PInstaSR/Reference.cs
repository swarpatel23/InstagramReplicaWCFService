﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InstagramApplication.PInstaSR {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Post", Namespace="http://schemas.datacontract.org/2004/07/InstagramReplicaService")]
    [System.SerializableAttribute()]
    public partial class Post : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime creation_dateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> likesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string locationField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string photopathField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int postIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string post_textField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int userIdField;
        
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
        public System.DateTime creation_date {
            get {
                return this.creation_dateField;
            }
            set {
                if ((this.creation_dateField.Equals(value) != true)) {
                    this.creation_dateField = value;
                    this.RaisePropertyChanged("creation_date");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> likes {
            get {
                return this.likesField;
            }
            set {
                if ((this.likesField.Equals(value) != true)) {
                    this.likesField = value;
                    this.RaisePropertyChanged("likes");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string location {
            get {
                return this.locationField;
            }
            set {
                if ((object.ReferenceEquals(this.locationField, value) != true)) {
                    this.locationField = value;
                    this.RaisePropertyChanged("location");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string photopath {
            get {
                return this.photopathField;
            }
            set {
                if ((object.ReferenceEquals(this.photopathField, value) != true)) {
                    this.photopathField = value;
                    this.RaisePropertyChanged("photopath");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int postId {
            get {
                return this.postIdField;
            }
            set {
                if ((this.postIdField.Equals(value) != true)) {
                    this.postIdField = value;
                    this.RaisePropertyChanged("postId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string post_text {
            get {
                return this.post_textField;
            }
            set {
                if ((object.ReferenceEquals(this.post_textField, value) != true)) {
                    this.post_textField = value;
                    this.RaisePropertyChanged("post_text");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int userId {
            get {
                return this.userIdField;
            }
            set {
                if ((this.userIdField.Equals(value) != true)) {
                    this.userIdField = value;
                    this.RaisePropertyChanged("userId");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="PInstaSR.IpostService")]
    public interface IpostService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IpostService/createPost", ReplyAction="http://tempuri.org/IpostService/createPostResponse")]
        void createPost(InstagramApplication.PInstaSR.Post post);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IpostService/createPost", ReplyAction="http://tempuri.org/IpostService/createPostResponse")]
        System.Threading.Tasks.Task createPostAsync(InstagramApplication.PInstaSR.Post post);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IpostService/deletePost", ReplyAction="http://tempuri.org/IpostService/deletePostResponse")]
        void deletePost(int postid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IpostService/deletePost", ReplyAction="http://tempuri.org/IpostService/deletePostResponse")]
        System.Threading.Tasks.Task deletePostAsync(int postid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IpostService/updatePost", ReplyAction="http://tempuri.org/IpostService/updatePostResponse")]
        void updatePost(InstagramApplication.PInstaSR.Post post);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IpostService/updatePost", ReplyAction="http://tempuri.org/IpostService/updatePostResponse")]
        System.Threading.Tasks.Task updatePostAsync(InstagramApplication.PInstaSR.Post post);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IpostService/fetchPost", ReplyAction="http://tempuri.org/IpostService/fetchPostResponse")]
        InstagramApplication.PInstaSR.Post[] fetchPost(int userid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IpostService/fetchPost", ReplyAction="http://tempuri.org/IpostService/fetchPostResponse")]
        System.Threading.Tasks.Task<InstagramApplication.PInstaSR.Post[]> fetchPostAsync(int userid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IpostService/incrementLike", ReplyAction="http://tempuri.org/IpostService/incrementLikeResponse")]
        System.Nullable<int> incrementLike(int likes, int postid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IpostService/incrementLike", ReplyAction="http://tempuri.org/IpostService/incrementLikeResponse")]
        System.Threading.Tasks.Task<System.Nullable<int>> incrementLikeAsync(int likes, int postid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IpostService/decrementLike", ReplyAction="http://tempuri.org/IpostService/decrementLikeResponse")]
        System.Nullable<int> decrementLike(int likes, int postid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IpostService/decrementLike", ReplyAction="http://tempuri.org/IpostService/decrementLikeResponse")]
        System.Threading.Tasks.Task<System.Nullable<int>> decrementLikeAsync(int likes, int postid);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IpostServiceChannel : InstagramApplication.PInstaSR.IpostService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class IpostServiceClient : System.ServiceModel.ClientBase<InstagramApplication.PInstaSR.IpostService>, InstagramApplication.PInstaSR.IpostService {
        
        public IpostServiceClient() {
        }
        
        public IpostServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public IpostServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public IpostServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public IpostServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void createPost(InstagramApplication.PInstaSR.Post post) {
            base.Channel.createPost(post);
        }
        
        public System.Threading.Tasks.Task createPostAsync(InstagramApplication.PInstaSR.Post post) {
            return base.Channel.createPostAsync(post);
        }
        
        public void deletePost(int postid) {
            base.Channel.deletePost(postid);
        }
        
        public System.Threading.Tasks.Task deletePostAsync(int postid) {
            return base.Channel.deletePostAsync(postid);
        }
        
        public void updatePost(InstagramApplication.PInstaSR.Post post) {
            base.Channel.updatePost(post);
        }
        
        public System.Threading.Tasks.Task updatePostAsync(InstagramApplication.PInstaSR.Post post) {
            return base.Channel.updatePostAsync(post);
        }
        
        public InstagramApplication.PInstaSR.Post[] fetchPost(int userid) {
            return base.Channel.fetchPost(userid);
        }
        
        public System.Threading.Tasks.Task<InstagramApplication.PInstaSR.Post[]> fetchPostAsync(int userid) {
            return base.Channel.fetchPostAsync(userid);
        }
        
        public System.Nullable<int> incrementLike(int likes, int postid) {
            return base.Channel.incrementLike(likes, postid);
        }
        
        public System.Threading.Tasks.Task<System.Nullable<int>> incrementLikeAsync(int likes, int postid) {
            return base.Channel.incrementLikeAsync(likes, postid);
        }
        
        public System.Nullable<int> decrementLike(int likes, int postid) {
            return base.Channel.decrementLike(likes, postid);
        }
        
        public System.Threading.Tasks.Task<System.Nullable<int>> decrementLikeAsync(int likes, int postid) {
            return base.Channel.decrementLikeAsync(likes, postid);
        }
    }
}
