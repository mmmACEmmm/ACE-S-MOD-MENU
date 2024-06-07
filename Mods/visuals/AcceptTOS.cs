using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Monkey_Magic_Menu.Mods.visuals
{
    internal class acceptTOS
    {
        public static void AcceptTOS()
        {
            GameObject.Find("Miscellaneous Scripts/LegalAgreementCheck/Legal Agreements").SetActive(false);
            GameObject.Find("Miscellaneous Scripts/LegalAgreementCheck/UIParent").SetActive(false);
        }
    }
}
