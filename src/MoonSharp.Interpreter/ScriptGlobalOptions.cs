using MoonSharp.Interpreter.Interop;
using MoonSharp.Interpreter.Platforms;

namespace MoonSharp.Interpreter
{
	/// <summary>
	/// Class containing script global options, that is options which cannot be customized per-script.
	/// <see cref="Script.GlobalOptions"/>
	/// </summary>
	public class ScriptGlobalOptions
	{
		internal ScriptGlobalOptions()
		{
			Platform = PlatformAutoDetector.GetDefaultPlatform();
			CustomConverters = new CustomConvertersCollection();
			UserDataCaseNameMatchingBehaviour = DescriptorCaseBehaviour.UpperFirstLetter;
			UserDataUnderlineNameMatchingBehaviour = DescriptorUnderlineBehaviour.Camelify;
		}

		/// <summary>
		/// Gets or sets the custom converters.
		/// </summary>
		public CustomConvertersCollection CustomConverters { get; set; }

		/// <summary>
		/// Gets or sets the platform abstraction to use.
		/// </summary>
		/// <value>
		/// The current platform abstraction.
		/// </value>
		public IPlatformAccessor Platform { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether interpreter exceptions should be 
		/// re-thrown as nested exceptions.
		/// </summary>
		public bool RethrowExceptionNested { get; set; }

		/// <summary>
		/// Gets or sets an enum that controls behaviour when a symbol (method, property, userdata) is not found in a userdata's descriptor. For instance,
		/// when this value is <see cref="DescriptorCaseBehaviour.UpperFirstLetter"/>, and Lua code calls the non-existent method <code>someuserdata.someMethod()</code>,
		/// <code>someuserdata.SomeMethod()</code> will also be tried. This can be used in addintion to <see cref="UserDataUnderlineNameMatchingBehaviour"/> to allow additional checks.
		/// </summary>
		public DescriptorCaseBehaviour UserDataCaseNameMatchingBehaviour { get; set; }

		/// <summary>
		/// Gets or sets an enum that controls behaviour when a symbol (method, property, userdata) is not found in a userdata's descriptor. For instance,
		/// when this value is <see cref="DescriptorUnderlineBehaviour.Camelify"/>, and Lua code calls the non-existent method <code>someuserdata.some_method()</code>,
		/// <code>someuserdata.SomeMethod()</code> will also be tried. This can be used in addintion to <see cref="UserDataCaseNameMatchingBehaviour"/> to allow additional checks.
		/// </summary>
		public DescriptorUnderlineBehaviour UserDataUnderlineNameMatchingBehaviour { get; set; }

	}
}
