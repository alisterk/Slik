﻿// We had to edit it and save because of the collision with Descriptor property

// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: protos/types/descriptor.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Containerd.Types
{

    /// <summary>Holder for reflection information generated from protos/types/descriptor.proto</summary>
    public static partial class DescriptorReflection
    {

        #region Descriptor
        /// <summary>File descriptor for protos/types/descriptor.proto</summary>
        public static pbr::FileDescriptor Descriptor
        {
            get { return descriptor; }
        }
        private static pbr::FileDescriptor descriptor;

        static DescriptorReflection()
        {
            byte[] descriptorData = global::System.Convert.FromBase64String(
                string.Concat(
                  "Ch1wcm90b3MvdHlwZXMvZGVzY3JpcHRvci5wcm90bxIQY29udGFpbmVyZC50",
                  "eXBlcxobcHJvdG9zL2dvZ29wcm90by9nb2dvLnByb3RvIuoBCgpEZXNjcmlw",
                  "dG9yEhIKCm1lZGlhX3R5cGUYASABKAkSQgoGZGlnZXN0GAIgASgJQjLa3h8q",
                  "Z2l0aHViLmNvbS9vcGVuY29udGFpbmVycy9nby1kaWdlc3QuRGlnZXN0yN4f",
                  "ABIMCgRzaXplGAMgASgDEkIKC2Fubm90YXRpb25zGAUgAygLMi0uY29udGFp",
                  "bmVyZC50eXBlcy5EZXNjcmlwdG9yLkFubm90YXRpb25zRW50cnkaMgoQQW5u",
                  "b3RhdGlvbnNFbnRyeRILCgNrZXkYASABKAkSDQoFdmFsdWUYAiABKAk6AjgB",
                  "QjJaMGdpdGh1Yi5jb20vY29udGFpbmVyZC9jb250YWluZXJkL2FwaS90eXBl",
                  "czt0eXBlc1gAYgZwcm90bzM="));
            descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
                new pbr::FileDescriptor[] { global::Gogoproto.GogoReflection.Descriptor, },
                new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Containerd.Types.Descriptor), global::Containerd.Types.Descriptor.Parser, new[]{ "MediaType", "Digest", "Size", "Annotations" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
                }));
        }
        #endregion

    }
    #region Messages
    /// <summary>
    /// Descriptor describes a blob in a content store.
    ///
    /// This descriptor can be used to reference content from an
    /// oci descriptor found in a manifest.
    /// See https://godoc.org/github.com/opencontainers/image-spec/specs-go/v1#Descriptor
    /// </summary>
    public sealed partial class Descriptor : pb::IMessage<Descriptor>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
#endif
    {
        private static readonly pb::MessageParser<Descriptor> _parser = new pb::MessageParser<Descriptor>(() => new Descriptor());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pb::MessageParser<Descriptor> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pbr::MessageDescriptor Descriptor_
        {
            get { return global::Containerd.Types.DescriptorReflection.Descriptor.MessageTypes[0]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        pbr::MessageDescriptor pb::IMessage.Descriptor
        {
            get { return Descriptor_; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public Descriptor()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public Descriptor(Descriptor other) : this()
        {
            mediaType_ = other.mediaType_;
            digest_ = other.digest_;
            size_ = other.size_;
            annotations_ = other.annotations_.Clone();
            _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public Descriptor Clone()
        {
            return new Descriptor(this);
        }

        /// <summary>Field number for the "media_type" field.</summary>
        public const int MediaTypeFieldNumber = 1;
        private string mediaType_ = "";
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public string MediaType
        {
            get { return mediaType_; }
            set
            {
                mediaType_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "digest" field.</summary>
        public const int DigestFieldNumber = 2;
        private string digest_ = "";
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public string Digest
        {
            get { return digest_; }
            set
            {
                digest_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "size" field.</summary>
        public const int SizeFieldNumber = 3;
        private long size_;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public long Size
        {
            get { return size_; }
            set
            {
                size_ = value;
            }
        }

        /// <summary>Field number for the "annotations" field.</summary>
        public const int AnnotationsFieldNumber = 5;
        private static readonly pbc::MapField<string, string>.Codec _map_annotations_codec
            = new pbc::MapField<string, string>.Codec(pb::FieldCodec.ForString(10, ""), pb::FieldCodec.ForString(18, ""), 42);
        private readonly pbc::MapField<string, string> annotations_ = new pbc::MapField<string, string>();
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public pbc::MapField<string, string> Annotations
        {
            get { return annotations_; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override bool Equals(object other)
        {
            return Equals(other as Descriptor);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool Equals(Descriptor other)
        {
            if (ReferenceEquals(other, null))
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (MediaType != other.MediaType) return false;
            if (Digest != other.Digest) return false;
            if (Size != other.Size) return false;
            if (!Annotations.Equals(other.Annotations)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override int GetHashCode()
        {
            int hash = 1;
            if (MediaType.Length != 0) hash ^= MediaType.GetHashCode();
            if (Digest.Length != 0) hash ^= Digest.GetHashCode();
            if (Size != 0L) hash ^= Size.GetHashCode();
            hash ^= Annotations.GetHashCode();
            if (_unknownFields != null)
            {
                hash ^= _unknownFields.GetHashCode();
            }
            return hash;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override string ToString()
        {
            return pb::JsonFormatter.ToDiagnosticString(this);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void WriteTo(pb::CodedOutputStream output)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            output.WriteRawMessage(this);
#else
      if (MediaType.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(MediaType);
      }
      if (Digest.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Digest);
      }
      if (Size != 0L) {
        output.WriteRawTag(24);
        output.WriteInt64(Size);
      }
      annotations_.WriteTo(output, _map_annotations_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output)
        {
            if (MediaType.Length != 0)
            {
                output.WriteRawTag(10);
                output.WriteString(MediaType);
            }
            if (Digest.Length != 0)
            {
                output.WriteRawTag(18);
                output.WriteString(Digest);
            }
            if (Size != 0L)
            {
                output.WriteRawTag(24);
                output.WriteInt64(Size);
            }
            annotations_.WriteTo(ref output, _map_annotations_codec);
            if (_unknownFields != null)
            {
                _unknownFields.WriteTo(ref output);
            }
        }
#endif

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int CalculateSize()
        {
            int size = 0;
            if (MediaType.Length != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeStringSize(MediaType);
            }
            if (Digest.Length != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeStringSize(Digest);
            }
            if (Size != 0L)
            {
                size += 1 + pb::CodedOutputStream.ComputeInt64Size(Size);
            }
            size += annotations_.CalculateSize(_map_annotations_codec);
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(Descriptor other)
        {
            if (other == null)
            {
                return;
            }
            if (other.MediaType.Length != 0)
            {
                MediaType = other.MediaType;
            }
            if (other.Digest.Length != 0)
            {
                Digest = other.Digest;
            }
            if (other.Size != 0L)
            {
                Size = other.Size;
            }
            annotations_.Add(other.annotations_);
            _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(pb::CodedInputStream input)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            input.ReadRawMessage(this);
#else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            MediaType = input.ReadString();
            break;
          }
          case 18: {
            Digest = input.ReadString();
            break;
          }
          case 24: {
            Size = input.ReadInt64();
            break;
          }
          case 42: {
            annotations_.AddEntriesFrom(input, _map_annotations_codec);
            break;
          }
        }
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                switch (tag)
                {
                    default:
                        _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
                        break;
                    case 10:
                        {
                            MediaType = input.ReadString();
                            break;
                        }
                    case 18:
                        {
                            Digest = input.ReadString();
                            break;
                        }
                    case 24:
                        {
                            Size = input.ReadInt64();
                            break;
                        }
                    case 42:
                        {
                            annotations_.AddEntriesFrom(ref input, _map_annotations_codec);
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
