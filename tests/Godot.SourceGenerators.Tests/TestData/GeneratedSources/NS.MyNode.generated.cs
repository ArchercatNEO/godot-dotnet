#nullable enable

namespace NS;

partial class MyNode
{
    public new partial class MethodName : global::Godot.Node.MethodName
    {
        public static global::Godot.StringName @MyMethod { get; } = global::Godot.StringName.CreateStaticFromAscii("MyMethod"u8);
    }
    public new partial class PropertyName : global::Godot.Node.PropertyName
    {
        public static global::Godot.StringName @MyProperty { get; } = global::Godot.StringName.CreateStaticFromAscii("MyProperty"u8);
    }
    public new partial class SignalName : global::Godot.Node.SignalName
    {
        public static global::Godot.StringName @MySignal { get; } = global::Godot.StringName.CreateStaticFromAscii("MySignal"u8);
    }
    internal static void BindMethods(global::Godot.Bridge.ClassDBRegistrationContext context)
    {
        context.BindConstructor(() => MyNode.@MyConstructorMethod());
        context.BindMethod(MethodName.@MyMethod,
            static (MyNode __instance) =>
            {
                __instance.@MyMethod();
            });
        context.BindProperty(new global::Godot.Bridge.PropertyInfo(PropertyName.@MyProperty, global::Godot.VariantType.Int, global::Godot.Bridge.VariantTypeMetadata.Int32)
            {
                Usage = global::Godot.PropertyUsageFlags.Default,
            },
            static (MyNode __instance) =>
            {
                return __instance.@MyProperty;
            },
            static (MyNode __instance, int value) =>
            {
                __instance.@MyProperty = value;
            });
        context.BindSignal(new global::Godot.Bridge.SignalInfo(SignalName.@MySignal));
    }
}
