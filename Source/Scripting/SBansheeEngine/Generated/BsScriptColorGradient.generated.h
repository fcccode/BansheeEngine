#pragma once

#include "BsScriptEnginePrerequisites.h"
#include "BsScriptObject.h"
#include "Image/BsColor.h"

namespace bs
{
	class ColorGradient;
	class ColorGradientEx;
	struct __ColorGradientKeyInterop;

	class BS_SCR_BE_EXPORT ScriptColorGradient : public ScriptObject<ScriptColorGradient>
	{
	public:
		SCRIPT_OBJ(ENGINE_ASSEMBLY, "BansheeEngine", "ColorGradient")

		ScriptColorGradient(MonoObject* managedInstance, const SPtr<ColorGradient>& value);

		SPtr<ColorGradient> getInternal() const { return mInternal; }
		static MonoObject* create(const SPtr<ColorGradient>& value);

	private:
		SPtr<ColorGradient> mInternal;

		static void Internal_ColorGradient(MonoObject* managedInstance);
		static void Internal_ColorGradient0(MonoObject* managedInstance, Color* color);
		static void Internal_ColorGradient1(MonoObject* managedInstance, MonoArray* keys);
		static void Internal_setKeys(ScriptColorGradient* thisPtr, MonoArray* keys, float duration);
		static MonoArray* Internal_getKeys(ScriptColorGradient* thisPtr);
		static void Internal_setConstant(ScriptColorGradient* thisPtr, Color* color);
		static void Internal_evaluate(ScriptColorGradient* thisPtr, float t, Color* __output);
	};
}
