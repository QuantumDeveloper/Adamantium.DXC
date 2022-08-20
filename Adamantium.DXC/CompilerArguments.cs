namespace Adamantium.DXC;

public class CompilerArguments
{
    /// <summary>
    /// Enables aggressive flattening
    /// </summary>
    public static string AllResourcesBound => "-all-resources-bound";

    /// <summary>
    /// Set auto binding space - enables auto resource binding in libraries
    /// </summary>
    public static string AutoBindingSpace => "-auto-binding-space";

    /// <summary>
    /// Define macro
    /// </summary>
    public static string Macro => "-D";

    /// <summary>
    /// Enable 16bit types and disable min precision types. Available in HLSL 2018 and shader model 6.2
    /// </summary>
    public static string Enable16BitTypes => "-enable-16bit-types";
    
    /// <summary>
    /// HLSL version (2016, 2017, 2018, 2021). Default is 2018
    /// </summary>
    public static string HLSLVersion => "-HV";

    /// <summary>
    /// Suppress warnings
    /// </summary>
    public static string NoWarnings => "-no-warnings";

    /// <summary>
    /// Treat warnings as errors
    /// </summary>
    public static string WarningsAsErrors => "-WX";
    
    // SPIRV section

    /// <summary>
    /// Specify SPIR-V extension permitted to use
    /// </summary>
    public static string SpvExtension => "-fspv-extension=";

    /// <summary>
    /// Flatten arrays of resources so each array element takes one binding number
    /// </summary>
    public static string SpvFlattenResourceArrays => "-fspv-flatten-resource-arrays";

    /// <summary>
    /// Emit additional SPIR-V instructions to aid reflection
    /// </summary>
    public static string SpvReflect => "-fspv-reflect";

    /// <summary>
    /// Specify the target environment: vulkan1.0 (default) or vulkan1.1
    /// </summary>
    public static string SpvTargetEnv => "-fspv-target-env=";

    /// <summary>
    /// Apply fvk-*-shift to resources without an explicit register assignment.
    /// </summary>
    public static string SpvAutoShiftBindings => "-fvk-auto-shift-bindings";

    /// <summary>
    /// Specify Vulkan binding number shift for b-type register
    /// </summary>
    public static string SpvFvkBShift => "-fvk-b-shift";

    /// <summary>
    /// Specify Vulkan binding number and set number for the $Globals cbuffer
    /// </summary>
    public static string SpvFvkBindGlobals => "-fvk-bind-globals";

    /// <summary>
    /// Specify Vulkan descriptor set and binding for a specific register
    /// </summary>
    public static string SpvFvkBindRegister => "-fvk-bind-register";

    /// <summary>
    /// Negate SV_Position.y before writing to stage output in VS/DS/GS to accommodate Vulkan’s coordinate system
    /// </summary>
    public static string SpvFvkInvertY => "-fvk-invert-y";

    /// <summary>
    /// Specify Vulkan binding number shift for s-type register
    /// </summary>
    public static string SpvFvkSShift => "-fvk-s-shift";

    /// <summary>
    /// Specify Vulkan binding number shift for t-type register
    /// </summary>
    public static string SpvFvkTShift => "-fvk-t-shift";

    /// <summary>
    /// Specify Vulkan binding number shift for u-type register
    /// </summary>
    public static string SpvFvkUShift => "-fvk-u-shift";

    /// <summary>
    /// Use DirectX memory layout for Vulkan resources
    /// </summary>
    public static string SpvUseDxLayout => "-fvk-use-dx-layout";

    /// <summary>
    /// Reciprocate SV_Position.w after reading from stage input in PS to accommodate the difference between Vulkan and DirectX
    /// </summary>
    public static string SpvUseDxPositionW => "-fvk-use-dx-position-w";

    /// <summary>
    /// Use scalar memory layout for Vulkan resources
    /// </summary>
    public static string SpvUseScalarLayout => "-fvk-use-scalar-layout";
}