﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ej2_blazor_samples;
namespace ej2_blazor_samples
{
    internal partial class SampleConfig
    {
        public List<Sample> Dialog { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Dialog",
                Directory = "Layout/Dialog",
                Url = "Layout/DefaultFunctionalities",
                FileName = "DefaultFunctionalities.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Draggable",
                Category = "Dialog",
                Directory = "Layout/Dialog",
                Url = "Layout/Draggable",
                FileName = "Draggable.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Resizable",
                Category = "Dialog",
                Directory = "Layout/Dialog",
                Url = "Layout/Resizable",
                FileName = "Resizable.razor",
                Type = SampleType.New
            }
        };
        public List<Sample> Splitter { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Splitter",
                Directory = "Layout/Splitter",
                Url = "Layout/Default",
                FileName = "Default.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Expand and Collapse",
                Category = "Splitter",
                Directory = "Layout/Splitter",
                Url = "Layout/ExpandandCollapse",
                FileName = "ExpandandCollapse.razor",
                Type = SampleType.New
            },
        };
    }
}
