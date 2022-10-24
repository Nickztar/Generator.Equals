﻿//HintName: Generator.Equals.Tests.RecordStructs.IgnoreEquality.Sample.Generator.Equals.g.cs

#nullable enable
#pragma warning disable CS0612,CS0618

namespace Generator.Equals.Tests.RecordStructs
{
    partial class IgnoreEquality
    {
        partial record struct Sample
        {
            /// <inheritdoc/>
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Generator.Equals", "1.0.0.0")]
            public bool Equals(global::Generator.Equals.Tests.RecordStructs.IgnoreEquality.Sample other)
            {
                return true
                    && global::System.Collections.Generic.EqualityComparer<global::System.String>.Default.Equals(Name!, other.Name!)
                    ;
            }
            
            /// <inheritdoc/>
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Generator.Equals", "1.0.0.0")]
            public override int GetHashCode()
            {
                var hashCode = new global::System.HashCode();
                
                hashCode.Add(
                    this.Name!,
                    global::System.Collections.Generic.EqualityComparer<global::System.String>.Default);
                
                return hashCode.ToHashCode();
            }
        }
    }
}
