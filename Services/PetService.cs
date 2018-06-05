// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: jp.tamagotchi.proto.business/service/pet/petService.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Jp.Tamagotchi.Business.Shared.Services.Pet {

  /// <summary>Holder for reflection information generated from jp.tamagotchi.proto.business/service/pet/petService.proto</summary>
  public static partial class PetServiceReflection {

    #region Descriptor
    /// <summary>File descriptor for jp.tamagotchi.proto.business/service/pet/petService.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PetServiceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjlqcC50YW1hZ290Y2hpLnByb3RvLmJ1c2luZXNzL3NlcnZpY2UvcGV0L3Bl",
            "dFNlcnZpY2UucHJvdG8SKmpwLnRhbWFnb3RjaGkuYnVzaW5lc3Muc2hhcmVk",
            "LnNlcnZpY2VzLnBldBo3anAudGFtYWdvdGNoaS5wcm90by5idXNpbmVzcy9z",
            "ZXJ2aWNlL3BldC9wZXRNb2RlbC5wcm90byJOCg5TYXZlUGV0UmVxdWVzdBI8",
            "CgNQZXQYASABKAsyLy5qcC50YW1hZ290Y2hpLmJ1c2luZXNzLnNoYXJlZC5z",
            "ZXJ2aWNlcy5wZXQuUGV0InMKD1NhdmVQZXRSZXNwb25zZRIRCglzdWNlc3Nm",
            "dWwYASABKAgSDwoHbWVzc2FnZRgCIAEoCRI8CgNwZXQYAyABKAsyLy5qcC50",
            "YW1hZ290Y2hpLmJ1c2luZXNzLnNoYXJlZC5zZXJ2aWNlcy5wZXQuUGV0ImAK",
            "DkdldFBldHNSZXF1ZXN0EgwKBHNpemUYASABKAUSQAoHZXhhbXBsZRgCIAEo",
            "CzIvLmpwLnRhbWFnb3RjaGkuYnVzaW5lc3Muc2hhcmVkLnNlcnZpY2VzLnBl",
            "dC5QZXQiYgoPR2V0UGV0c1Jlc3BvbnNlEhEKCXN1Y2Vzc2Z1bBgBIAEoCBI8",
            "CgNwZXQYAiADKAsyLy5qcC50YW1hZ290Y2hpLmJ1c2luZXNzLnNoYXJlZC5z",
            "ZXJ2aWNlcy5wZXQuUGV0MpYCCgpQZXRTZXJ2aWNlEoIBCgdTYXZlUGV0Ejou",
            "anAudGFtYWdvdGNoaS5idXNpbmVzcy5zaGFyZWQuc2VydmljZXMucGV0LlNh",
            "dmVQZXRSZXF1ZXN0GjsuanAudGFtYWdvdGNoaS5idXNpbmVzcy5zaGFyZWQu",
            "c2VydmljZXMucGV0LlNhdmVQZXRSZXNwb25zZRKCAQoHR2V0UGV0cxI6Lmpw",
            "LnRhbWFnb3RjaGkuYnVzaW5lc3Muc2hhcmVkLnNlcnZpY2VzLnBldC5HZXRQ",
            "ZXRzUmVxdWVzdBo7LmpwLnRhbWFnb3RjaGkuYnVzaW5lc3Muc2hhcmVkLnNl",
            "cnZpY2VzLnBldC5HZXRQZXRzUmVzcG9uc2VCLAoqanAudGFtYWdvdGNoaS5i",
            "dXNpbmVzcy5zaGFyZWQuc2VydmljZXMucGV0YgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Jp.Tamagotchi.Business.Shared.Services.Pet.PetModelReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Jp.Tamagotchi.Business.Shared.Services.Pet.SavePetRequest), global::Jp.Tamagotchi.Business.Shared.Services.Pet.SavePetRequest.Parser, new[]{ "Pet" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Jp.Tamagotchi.Business.Shared.Services.Pet.SavePetResponse), global::Jp.Tamagotchi.Business.Shared.Services.Pet.SavePetResponse.Parser, new[]{ "Sucessful", "Message", "Pet" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Jp.Tamagotchi.Business.Shared.Services.Pet.GetPetsRequest), global::Jp.Tamagotchi.Business.Shared.Services.Pet.GetPetsRequest.Parser, new[]{ "Size", "Example" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Jp.Tamagotchi.Business.Shared.Services.Pet.GetPetsResponse), global::Jp.Tamagotchi.Business.Shared.Services.Pet.GetPetsResponse.Parser, new[]{ "Sucessful", "Pet" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class SavePetRequest : pb::IMessage<SavePetRequest> {
    private static readonly pb::MessageParser<SavePetRequest> _parser = new pb::MessageParser<SavePetRequest>(() => new SavePetRequest());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<SavePetRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Jp.Tamagotchi.Business.Shared.Services.Pet.PetServiceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SavePetRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SavePetRequest(SavePetRequest other) : this() {
      Pet = other.pet_ != null ? other.Pet.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SavePetRequest Clone() {
      return new SavePetRequest(this);
    }

    /// <summary>Field number for the "Pet" field.</summary>
    public const int PetFieldNumber = 1;
    private global::Jp.Tamagotchi.Business.Shared.Services.Pet.Pet pet_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Jp.Tamagotchi.Business.Shared.Services.Pet.Pet Pet {
      get { return pet_; }
      set {
        pet_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as SavePetRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(SavePetRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Pet, other.Pet)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (pet_ != null) hash ^= Pet.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (pet_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Pet);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (pet_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Pet);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(SavePetRequest other) {
      if (other == null) {
        return;
      }
      if (other.pet_ != null) {
        if (pet_ == null) {
          pet_ = new global::Jp.Tamagotchi.Business.Shared.Services.Pet.Pet();
        }
        Pet.MergeFrom(other.Pet);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            if (pet_ == null) {
              pet_ = new global::Jp.Tamagotchi.Business.Shared.Services.Pet.Pet();
            }
            input.ReadMessage(pet_);
            break;
          }
        }
      }
    }

  }

  public sealed partial class SavePetResponse : pb::IMessage<SavePetResponse> {
    private static readonly pb::MessageParser<SavePetResponse> _parser = new pb::MessageParser<SavePetResponse>(() => new SavePetResponse());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<SavePetResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Jp.Tamagotchi.Business.Shared.Services.Pet.PetServiceReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SavePetResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SavePetResponse(SavePetResponse other) : this() {
      sucessful_ = other.sucessful_;
      message_ = other.message_;
      Pet = other.pet_ != null ? other.Pet.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SavePetResponse Clone() {
      return new SavePetResponse(this);
    }

    /// <summary>Field number for the "sucessful" field.</summary>
    public const int SucessfulFieldNumber = 1;
    private bool sucessful_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Sucessful {
      get { return sucessful_; }
      set {
        sucessful_ = value;
      }
    }

    /// <summary>Field number for the "message" field.</summary>
    public const int MessageFieldNumber = 2;
    private string message_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Message {
      get { return message_; }
      set {
        message_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "pet" field.</summary>
    public const int PetFieldNumber = 3;
    private global::Jp.Tamagotchi.Business.Shared.Services.Pet.Pet pet_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Jp.Tamagotchi.Business.Shared.Services.Pet.Pet Pet {
      get { return pet_; }
      set {
        pet_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as SavePetResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(SavePetResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Sucessful != other.Sucessful) return false;
      if (Message != other.Message) return false;
      if (!object.Equals(Pet, other.Pet)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Sucessful != false) hash ^= Sucessful.GetHashCode();
      if (Message.Length != 0) hash ^= Message.GetHashCode();
      if (pet_ != null) hash ^= Pet.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Sucessful != false) {
        output.WriteRawTag(8);
        output.WriteBool(Sucessful);
      }
      if (Message.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Message);
      }
      if (pet_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Pet);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Sucessful != false) {
        size += 1 + 1;
      }
      if (Message.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Message);
      }
      if (pet_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Pet);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(SavePetResponse other) {
      if (other == null) {
        return;
      }
      if (other.Sucessful != false) {
        Sucessful = other.Sucessful;
      }
      if (other.Message.Length != 0) {
        Message = other.Message;
      }
      if (other.pet_ != null) {
        if (pet_ == null) {
          pet_ = new global::Jp.Tamagotchi.Business.Shared.Services.Pet.Pet();
        }
        Pet.MergeFrom(other.Pet);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            Sucessful = input.ReadBool();
            break;
          }
          case 18: {
            Message = input.ReadString();
            break;
          }
          case 26: {
            if (pet_ == null) {
              pet_ = new global::Jp.Tamagotchi.Business.Shared.Services.Pet.Pet();
            }
            input.ReadMessage(pet_);
            break;
          }
        }
      }
    }

  }

  public sealed partial class GetPetsRequest : pb::IMessage<GetPetsRequest> {
    private static readonly pb::MessageParser<GetPetsRequest> _parser = new pb::MessageParser<GetPetsRequest>(() => new GetPetsRequest());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetPetsRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Jp.Tamagotchi.Business.Shared.Services.Pet.PetServiceReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetPetsRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetPetsRequest(GetPetsRequest other) : this() {
      size_ = other.size_;
      Example = other.example_ != null ? other.Example.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetPetsRequest Clone() {
      return new GetPetsRequest(this);
    }

    /// <summary>Field number for the "size" field.</summary>
    public const int SizeFieldNumber = 1;
    private int size_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Size {
      get { return size_; }
      set {
        size_ = value;
      }
    }

    /// <summary>Field number for the "example" field.</summary>
    public const int ExampleFieldNumber = 2;
    private global::Jp.Tamagotchi.Business.Shared.Services.Pet.Pet example_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Jp.Tamagotchi.Business.Shared.Services.Pet.Pet Example {
      get { return example_; }
      set {
        example_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GetPetsRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetPetsRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Size != other.Size) return false;
      if (!object.Equals(Example, other.Example)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Size != 0) hash ^= Size.GetHashCode();
      if (example_ != null) hash ^= Example.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Size != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Size);
      }
      if (example_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Example);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Size != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Size);
      }
      if (example_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Example);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GetPetsRequest other) {
      if (other == null) {
        return;
      }
      if (other.Size != 0) {
        Size = other.Size;
      }
      if (other.example_ != null) {
        if (example_ == null) {
          example_ = new global::Jp.Tamagotchi.Business.Shared.Services.Pet.Pet();
        }
        Example.MergeFrom(other.Example);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            Size = input.ReadInt32();
            break;
          }
          case 18: {
            if (example_ == null) {
              example_ = new global::Jp.Tamagotchi.Business.Shared.Services.Pet.Pet();
            }
            input.ReadMessage(example_);
            break;
          }
        }
      }
    }

  }

  public sealed partial class GetPetsResponse : pb::IMessage<GetPetsResponse> {
    private static readonly pb::MessageParser<GetPetsResponse> _parser = new pb::MessageParser<GetPetsResponse>(() => new GetPetsResponse());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetPetsResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Jp.Tamagotchi.Business.Shared.Services.Pet.PetServiceReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetPetsResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetPetsResponse(GetPetsResponse other) : this() {
      sucessful_ = other.sucessful_;
      pet_ = other.pet_.Clone();
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetPetsResponse Clone() {
      return new GetPetsResponse(this);
    }

    /// <summary>Field number for the "sucessful" field.</summary>
    public const int SucessfulFieldNumber = 1;
    private bool sucessful_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Sucessful {
      get { return sucessful_; }
      set {
        sucessful_ = value;
      }
    }

    /// <summary>Field number for the "pet" field.</summary>
    public const int PetFieldNumber = 2;
    private static readonly pb::FieldCodec<global::Jp.Tamagotchi.Business.Shared.Services.Pet.Pet> _repeated_pet_codec
        = pb::FieldCodec.ForMessage(18, global::Jp.Tamagotchi.Business.Shared.Services.Pet.Pet.Parser);
    private readonly pbc::RepeatedField<global::Jp.Tamagotchi.Business.Shared.Services.Pet.Pet> pet_ = new pbc::RepeatedField<global::Jp.Tamagotchi.Business.Shared.Services.Pet.Pet>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Jp.Tamagotchi.Business.Shared.Services.Pet.Pet> Pet {
      get { return pet_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GetPetsResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetPetsResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Sucessful != other.Sucessful) return false;
      if(!pet_.Equals(other.pet_)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Sucessful != false) hash ^= Sucessful.GetHashCode();
      hash ^= pet_.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Sucessful != false) {
        output.WriteRawTag(8);
        output.WriteBool(Sucessful);
      }
      pet_.WriteTo(output, _repeated_pet_codec);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Sucessful != false) {
        size += 1 + 1;
      }
      size += pet_.CalculateSize(_repeated_pet_codec);
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GetPetsResponse other) {
      if (other == null) {
        return;
      }
      if (other.Sucessful != false) {
        Sucessful = other.Sucessful;
      }
      pet_.Add(other.pet_);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            Sucessful = input.ReadBool();
            break;
          }
          case 18: {
            pet_.AddEntriesFrom(input, _repeated_pet_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code