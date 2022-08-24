﻿using System;
using System.Collections.Generic;

namespace Volo.Docs.Documents.Filter;

public class FilterVersionItem
{
    public string Version { get; set; }
    public string Format { get; set; }
    public string LanguageCode { get; set; }
    public Guid ProjectId { get; set; }
}