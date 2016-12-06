// This is the main DLL file.

#include "stdafx.h"

#include "MedvedC++.h"

void main()
{
	MedvedC::MedvedC^ medved = gcnew MedvedC::MedvedC();
	medved->MeetMedved();
}
