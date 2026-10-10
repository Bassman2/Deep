using Microsoft.CodeAnalysis;

namespace Deep.SourceGenerators;

partial class DeepGenerator
{
    protected void CreateAttributes(IncrementalGeneratorPostInitializationContext context)
    {
        context.AddSource($"ObservableModelAttributes.g.cs",
            """
            namespace Deep;

            public enum DeepType { All, Copy, Equal };

            [AttributeUsage(AttributeTargets.Class)]
            public class DeepAttribute(DeepType deepType = DeepType.All): Attribute
            { 
                public DeepType DeepType { get; } = modelType;
            }
            """);
    }

}
