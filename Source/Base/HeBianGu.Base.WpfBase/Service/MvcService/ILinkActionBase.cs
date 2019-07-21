﻿using System.Threading.Tasks;

namespace HeBianGu.Base.WpfBase
{
    public interface ILinkActionBase
    {
        string Action { get; set; }

        IActionResult ActionResult();

        string Controller { get; set; }

        string DisplayName { get; set; }

        string Logo { get; set; }
    }
}