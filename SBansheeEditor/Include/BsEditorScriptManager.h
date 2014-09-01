#pragma once

#include "BsScriptEditorPrerequisites.h"
#include "BsModule.h"

namespace BansheeEngine
{
	class BS_SCR_BED_EXPORT EditorScriptManager : public Module<EditorScriptManager>
	{
	public:
		EditorScriptManager();

		void update();

	private:
		static const float EDITOR_UPDATE_RATE;

		MonoAssembly* mEditorAssembly;
		float mLastUpdateTime;

		MonoClass* mProgramEdClass;
		MonoMethod* mUpdateMethod;
	};
}