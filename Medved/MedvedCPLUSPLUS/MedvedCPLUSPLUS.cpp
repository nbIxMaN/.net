// This is the main DLL file.

#include "stdafx.h"

using namespace System;
using namespace MedvedFSHARP;

public ref class MedvedC : MedvedFSHARP
{
public: void MeetMedved() override
{
	System::Console::WriteLine("Preved from C++");
	MedvedFSHARP::MeetMedved();
}
		// TODO: Add your methods for this class here.
};

void main()
{
	MedvedC^ medved = gcnew MedvedC();
	medved->MeetMedved();
}
