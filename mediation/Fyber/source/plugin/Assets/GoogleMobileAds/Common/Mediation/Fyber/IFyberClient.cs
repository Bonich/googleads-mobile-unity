// Copyright 2019 Google LLC
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

namespace GoogleMobileAds.Common.Mediation.Fyber
{
    public interface IFyberClient
    {
        /// <summary>
        /// Forwards user consent status to the Fyber Marketplace SDK.
        /// </summary>
        /// <param name="consent">the user's consent.</param>
        void SetGDPRConsent(bool consent);

        /// <summary>
        /// Forwards user consent string to the Fyber Marketplace SDK.
        /// </summary>
        /// <param name="consentString">the GDPR consent string.</param>
        void SetGDPRConsentString(string consentString);

        /// <summary>
        /// Clears GDPR consent data from the Fyber Marketplace SDK.
        /// </summary>
        void ClearGDPRConsentData();
    }
}
