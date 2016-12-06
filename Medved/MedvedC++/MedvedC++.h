// MedvedC++.h

#pragma once

using namespace System;
using namespace MedvedFSHARP;

namespace MedvedC {

	public ref class MedvedC : MedvedFSHARP
	{
	public: MedvedC() 
	{

	}
	public: void MeetMedved() override
		{
			System::Console::WriteLine("Hello from c++");
		}
		// TODO: Add your methods for this class here.
	};
}
