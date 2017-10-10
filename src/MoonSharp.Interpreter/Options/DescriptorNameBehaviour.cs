using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MoonSharp.Interpreter {

	/// <summary>
	/// Controls how letter cases in symbol names in Lua will be treated if the original symbol could not be found. For instance,
	/// if the Lua code <code>someuserdata.someMethod()</code> does not call a valid function in <code>someuserdata</code>, additional
	/// function names can be checked for to allow consistent code style in both Lua and .NET code. If this additional check does not
	/// find a symbol; and additional checks are enabled, they will be combined. If no checks find the symbol, an exception will be thrown.
	/// </summary>
	public enum DescriptorCaseBehaviour
	{
		/// <summary>Converts first letter of descriptor name to uppercase: someMethodName to SomeMethodName.</summary>
		UpperFirstLetter,

		/// <summary>No additional case checks to names will be performed.</summary>
		None

	}

	/// <summary>
	/// Controls how underlines in symbol names in Lua will be treated if the original symbol could not be found. For instance,
	/// if the Lua code <code>someuserdata.some_method()</code> does not call a valid function in <code>someuserdata</code>, additional
	/// function names can be checked for to allow consistent code style in both Lua and .NET code. If this additional check does not
	/// find a symbol; and additional checks are enabled, they will be combined. If no checks find the symbol, an exception will be thrown.
	/// </summary>
	public enum DescriptorUnderlineBehaviour
	{

		/// <summary>Converts descriptor name to camelcase: some_method_name to someMethodName.</summary>
		Camelify,

		/// <summary>No additional underlined checks to names will be performed.</summary>
		None

	}

}
