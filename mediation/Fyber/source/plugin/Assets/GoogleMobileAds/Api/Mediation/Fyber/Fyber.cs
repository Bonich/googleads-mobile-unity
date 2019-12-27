﻿// Copyright 2019 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//      http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using UnityEngine;

using GoogleMobileAds.Common.Mediation.Fyber;
using GoogleMobileAds.Mediation;

namespace GoogleMobileAds.Api.Mediation.Fyber
{
    public class Fyber
    {
        public static readonly IFyberClient client = GetFyberClient();

        private static IFyberClient GetFyberClient()
        {
            return FyberClientFactory.FyberInstance();
        }

        public static void SetGDPRConsent(bool consent)
        {
            client.SetGDPRConsent(consent);
        }

        public static void SetGDPRConsentString(string consentString)
        {
            if (consentString == null)
            {
                Debug.Log("Error: Consent string is null.");
                return;
            }

            client.SetGDPRConsentString(consentString);
        }

        public static void ClearGDPRConsentData()
        {
            client.ClearGDPRConsentData();
        }
    }
}
