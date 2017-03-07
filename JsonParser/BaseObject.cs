﻿/// <summary>
/// Base class used for JSON Values
/// </summary>

namespace JSONParser
{
    abstract class BaseObject
    {
        public abstract string Print(int indent);
        public abstract int GetWeight();
    }
}
