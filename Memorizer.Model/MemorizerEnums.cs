using System;
using System.Collections.Generic;
using System.Text;

namespace Memorizer.Models
{
    public enum StudyingDataType : int
    {
        Phrase = 0,
        Grammar = 1,
        Article = 2
    }

    public enum LearningStatus : int
    {
        New = 0,
        InProgress = 1,
        Done = 2
    }
}
