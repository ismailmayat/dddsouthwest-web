﻿using System.Collections.Generic;
using DDDSouthWest.Domain.Features.Account.Admin.ManagePages.ListPages;

namespace DDDSouthWest.Website.Features.Admin.Account.ManagePages
{
    public class ManagePagesListViewModel
    {
        public IList<PageListModel> Pages { get; set; }
    }
}