// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: NestedMessage.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace ProtobufDecoder.Application.Wpf.Test.Unit {

  /// <summary>Holder for reflection information generated from NestedMessage.proto</summary>
  public static partial class NestedMessageReflection {

    #region Descriptor
    /// <summary>File descriptor for NestedMessage.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static NestedMessageReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChNOZXN0ZWRNZXNzYWdlLnByb3RvEhlQcm90b2J1ZkRlY29kZXJfVGVzdF9V",
            "bml0InsKCE1lc3NhZ2UxEhAKCGludFZhbHVlGAEgASgFEhEKCWJ5dGVWYWx1",
            "ZRgCIAEoDBITCgtzdHJpbmdWYWx1ZRgDIAEoCRI1CghvYmpWYWx1ZRgEIAEo",
            "CzIjLlByb3RvYnVmRGVjb2Rlcl9UZXN0X1VuaXQuTWVzc2FnZTIiewoITWVz",
            "c2FnZTISEAoIaW50VmFsdWUYASABKAUSEQoJYnl0ZVZhbHVlGAIgASgMEhMK",
            "C3N0cmluZ1ZhbHVlGAMgASgJEjUKCG9ialZhbHVlGAQgASgLMiMuUHJvdG9i",
            "dWZEZWNvZGVyX1Rlc3RfVW5pdC5NZXNzYWdlMyJECghNZXNzYWdlMxIQCghp",
            "bnRWYWx1ZRgBIAEoBRIRCglieXRlVmFsdWUYAiABKAwSEwoLc3RyaW5nVmFs",
            "dWUYAyABKAlCLKoCKVByb3RvYnVmRGVjb2Rlci5BcHBsaWNhdGlvbi5XcGYu",
            "VGVzdC5Vbml0YgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::ProtobufDecoder.Application.Wpf.Test.Unit.Message1), global::ProtobufDecoder.Application.Wpf.Test.Unit.Message1.Parser, new[]{ "IntValue", "ByteValue", "StringValue", "ObjValue" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::ProtobufDecoder.Application.Wpf.Test.Unit.Message2), global::ProtobufDecoder.Application.Wpf.Test.Unit.Message2.Parser, new[]{ "IntValue", "ByteValue", "StringValue", "ObjValue" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::ProtobufDecoder.Application.Wpf.Test.Unit.Message3), global::ProtobufDecoder.Application.Wpf.Test.Unit.Message3.Parser, new[]{ "IntValue", "ByteValue", "StringValue" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Message1 : pb::IMessage<Message1>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Message1> _parser = new pb::MessageParser<Message1>(() => new Message1());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Message1> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::ProtobufDecoder.Application.Wpf.Test.Unit.NestedMessageReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Message1() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Message1(Message1 other) : this() {
      intValue_ = other.intValue_;
      byteValue_ = other.byteValue_;
      stringValue_ = other.stringValue_;
      objValue_ = other.objValue_ != null ? other.objValue_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Message1 Clone() {
      return new Message1(this);
    }

    /// <summary>Field number for the "intValue" field.</summary>
    public const int IntValueFieldNumber = 1;
    private int intValue_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int IntValue {
      get { return intValue_; }
      set {
        intValue_ = value;
      }
    }

    /// <summary>Field number for the "byteValue" field.</summary>
    public const int ByteValueFieldNumber = 2;
    private pb::ByteString byteValue_ = pb::ByteString.Empty;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pb::ByteString ByteValue {
      get { return byteValue_; }
      set {
        byteValue_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "stringValue" field.</summary>
    public const int StringValueFieldNumber = 3;
    private string stringValue_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string StringValue {
      get { return stringValue_; }
      set {
        stringValue_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "objValue" field.</summary>
    public const int ObjValueFieldNumber = 4;
    private global::ProtobufDecoder.Application.Wpf.Test.Unit.Message2 objValue_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::ProtobufDecoder.Application.Wpf.Test.Unit.Message2 ObjValue {
      get { return objValue_; }
      set {
        objValue_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Message1);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Message1 other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (IntValue != other.IntValue) return false;
      if (ByteValue != other.ByteValue) return false;
      if (StringValue != other.StringValue) return false;
      if (!object.Equals(ObjValue, other.ObjValue)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (IntValue != 0) hash ^= IntValue.GetHashCode();
      if (ByteValue.Length != 0) hash ^= ByteValue.GetHashCode();
      if (StringValue.Length != 0) hash ^= StringValue.GetHashCode();
      if (objValue_ != null) hash ^= ObjValue.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (IntValue != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(IntValue);
      }
      if (ByteValue.Length != 0) {
        output.WriteRawTag(18);
        output.WriteBytes(ByteValue);
      }
      if (StringValue.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(StringValue);
      }
      if (objValue_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(ObjValue);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (IntValue != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(IntValue);
      }
      if (ByteValue.Length != 0) {
        output.WriteRawTag(18);
        output.WriteBytes(ByteValue);
      }
      if (StringValue.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(StringValue);
      }
      if (objValue_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(ObjValue);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (IntValue != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(IntValue);
      }
      if (ByteValue.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(ByteValue);
      }
      if (StringValue.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(StringValue);
      }
      if (objValue_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ObjValue);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Message1 other) {
      if (other == null) {
        return;
      }
      if (other.IntValue != 0) {
        IntValue = other.IntValue;
      }
      if (other.ByteValue.Length != 0) {
        ByteValue = other.ByteValue;
      }
      if (other.StringValue.Length != 0) {
        StringValue = other.StringValue;
      }
      if (other.objValue_ != null) {
        if (objValue_ == null) {
          ObjValue = new global::ProtobufDecoder.Application.Wpf.Test.Unit.Message2();
        }
        ObjValue.MergeFrom(other.ObjValue);
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            IntValue = input.ReadInt32();
            break;
          }
          case 18: {
            ByteValue = input.ReadBytes();
            break;
          }
          case 26: {
            StringValue = input.ReadString();
            break;
          }
          case 34: {
            if (objValue_ == null) {
              ObjValue = new global::ProtobufDecoder.Application.Wpf.Test.Unit.Message2();
            }
            input.ReadMessage(ObjValue);
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 8: {
            IntValue = input.ReadInt32();
            break;
          }
          case 18: {
            ByteValue = input.ReadBytes();
            break;
          }
          case 26: {
            StringValue = input.ReadString();
            break;
          }
          case 34: {
            if (objValue_ == null) {
              ObjValue = new global::ProtobufDecoder.Application.Wpf.Test.Unit.Message2();
            }
            input.ReadMessage(ObjValue);
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class Message2 : pb::IMessage<Message2>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Message2> _parser = new pb::MessageParser<Message2>(() => new Message2());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Message2> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::ProtobufDecoder.Application.Wpf.Test.Unit.NestedMessageReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Message2() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Message2(Message2 other) : this() {
      intValue_ = other.intValue_;
      byteValue_ = other.byteValue_;
      stringValue_ = other.stringValue_;
      objValue_ = other.objValue_ != null ? other.objValue_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Message2 Clone() {
      return new Message2(this);
    }

    /// <summary>Field number for the "intValue" field.</summary>
    public const int IntValueFieldNumber = 1;
    private int intValue_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int IntValue {
      get { return intValue_; }
      set {
        intValue_ = value;
      }
    }

    /// <summary>Field number for the "byteValue" field.</summary>
    public const int ByteValueFieldNumber = 2;
    private pb::ByteString byteValue_ = pb::ByteString.Empty;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pb::ByteString ByteValue {
      get { return byteValue_; }
      set {
        byteValue_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "stringValue" field.</summary>
    public const int StringValueFieldNumber = 3;
    private string stringValue_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string StringValue {
      get { return stringValue_; }
      set {
        stringValue_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "objValue" field.</summary>
    public const int ObjValueFieldNumber = 4;
    private global::ProtobufDecoder.Application.Wpf.Test.Unit.Message3 objValue_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::ProtobufDecoder.Application.Wpf.Test.Unit.Message3 ObjValue {
      get { return objValue_; }
      set {
        objValue_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Message2);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Message2 other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (IntValue != other.IntValue) return false;
      if (ByteValue != other.ByteValue) return false;
      if (StringValue != other.StringValue) return false;
      if (!object.Equals(ObjValue, other.ObjValue)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (IntValue != 0) hash ^= IntValue.GetHashCode();
      if (ByteValue.Length != 0) hash ^= ByteValue.GetHashCode();
      if (StringValue.Length != 0) hash ^= StringValue.GetHashCode();
      if (objValue_ != null) hash ^= ObjValue.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (IntValue != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(IntValue);
      }
      if (ByteValue.Length != 0) {
        output.WriteRawTag(18);
        output.WriteBytes(ByteValue);
      }
      if (StringValue.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(StringValue);
      }
      if (objValue_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(ObjValue);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (IntValue != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(IntValue);
      }
      if (ByteValue.Length != 0) {
        output.WriteRawTag(18);
        output.WriteBytes(ByteValue);
      }
      if (StringValue.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(StringValue);
      }
      if (objValue_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(ObjValue);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (IntValue != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(IntValue);
      }
      if (ByteValue.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(ByteValue);
      }
      if (StringValue.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(StringValue);
      }
      if (objValue_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ObjValue);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Message2 other) {
      if (other == null) {
        return;
      }
      if (other.IntValue != 0) {
        IntValue = other.IntValue;
      }
      if (other.ByteValue.Length != 0) {
        ByteValue = other.ByteValue;
      }
      if (other.StringValue.Length != 0) {
        StringValue = other.StringValue;
      }
      if (other.objValue_ != null) {
        if (objValue_ == null) {
          ObjValue = new global::ProtobufDecoder.Application.Wpf.Test.Unit.Message3();
        }
        ObjValue.MergeFrom(other.ObjValue);
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            IntValue = input.ReadInt32();
            break;
          }
          case 18: {
            ByteValue = input.ReadBytes();
            break;
          }
          case 26: {
            StringValue = input.ReadString();
            break;
          }
          case 34: {
            if (objValue_ == null) {
              ObjValue = new global::ProtobufDecoder.Application.Wpf.Test.Unit.Message3();
            }
            input.ReadMessage(ObjValue);
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 8: {
            IntValue = input.ReadInt32();
            break;
          }
          case 18: {
            ByteValue = input.ReadBytes();
            break;
          }
          case 26: {
            StringValue = input.ReadString();
            break;
          }
          case 34: {
            if (objValue_ == null) {
              ObjValue = new global::ProtobufDecoder.Application.Wpf.Test.Unit.Message3();
            }
            input.ReadMessage(ObjValue);
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class Message3 : pb::IMessage<Message3>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Message3> _parser = new pb::MessageParser<Message3>(() => new Message3());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Message3> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::ProtobufDecoder.Application.Wpf.Test.Unit.NestedMessageReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Message3() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Message3(Message3 other) : this() {
      intValue_ = other.intValue_;
      byteValue_ = other.byteValue_;
      stringValue_ = other.stringValue_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Message3 Clone() {
      return new Message3(this);
    }

    /// <summary>Field number for the "intValue" field.</summary>
    public const int IntValueFieldNumber = 1;
    private int intValue_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int IntValue {
      get { return intValue_; }
      set {
        intValue_ = value;
      }
    }

    /// <summary>Field number for the "byteValue" field.</summary>
    public const int ByteValueFieldNumber = 2;
    private pb::ByteString byteValue_ = pb::ByteString.Empty;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pb::ByteString ByteValue {
      get { return byteValue_; }
      set {
        byteValue_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "stringValue" field.</summary>
    public const int StringValueFieldNumber = 3;
    private string stringValue_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string StringValue {
      get { return stringValue_; }
      set {
        stringValue_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Message3);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Message3 other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (IntValue != other.IntValue) return false;
      if (ByteValue != other.ByteValue) return false;
      if (StringValue != other.StringValue) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (IntValue != 0) hash ^= IntValue.GetHashCode();
      if (ByteValue.Length != 0) hash ^= ByteValue.GetHashCode();
      if (StringValue.Length != 0) hash ^= StringValue.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (IntValue != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(IntValue);
      }
      if (ByteValue.Length != 0) {
        output.WriteRawTag(18);
        output.WriteBytes(ByteValue);
      }
      if (StringValue.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(StringValue);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (IntValue != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(IntValue);
      }
      if (ByteValue.Length != 0) {
        output.WriteRawTag(18);
        output.WriteBytes(ByteValue);
      }
      if (StringValue.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(StringValue);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (IntValue != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(IntValue);
      }
      if (ByteValue.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(ByteValue);
      }
      if (StringValue.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(StringValue);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Message3 other) {
      if (other == null) {
        return;
      }
      if (other.IntValue != 0) {
        IntValue = other.IntValue;
      }
      if (other.ByteValue.Length != 0) {
        ByteValue = other.ByteValue;
      }
      if (other.StringValue.Length != 0) {
        StringValue = other.StringValue;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            IntValue = input.ReadInt32();
            break;
          }
          case 18: {
            ByteValue = input.ReadBytes();
            break;
          }
          case 26: {
            StringValue = input.ReadString();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 8: {
            IntValue = input.ReadInt32();
            break;
          }
          case 18: {
            ByteValue = input.ReadBytes();
            break;
          }
          case 26: {
            StringValue = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
