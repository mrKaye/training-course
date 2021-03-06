﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace pcsdk_validation.Services {
  public class Country {
    public string Iso2Code { get; set; }
    public string Name { get; set; }
  }

  public class CountryService {
    public async static Task<IEnumerable<Country>> List() {
      return new List<Country> {
        new Country { Name = "Afghanistan", Iso2Code = "AF" },
        new Country { Name = "ALA Aland Islands", Iso2Code = "AX" },
        new Country { Name = "Albania", Iso2Code = "AL" },
        new Country { Name = "Algeria", Iso2Code = "DZ" },
        new Country { Name = "American Samoa", Iso2Code = "AS" },
        new Country { Name = "Andorra", Iso2Code = "AD" },
        new Country { Name = "Angola", Iso2Code = "AO" },
        new Country { Name = "Anguilla", Iso2Code = "AI" },
        new Country { Name = "Antarctica", Iso2Code = "AQ" },
        new Country { Name = "Antigua and Barbuda", Iso2Code = "AG" },
        new Country { Name = "Argentina", Iso2Code = "AR" },
        new Country { Name = "Armenia", Iso2Code = "AM" },
        new Country { Name = "Aruba", Iso2Code = "AW" },
        new Country { Name = "Australia", Iso2Code = "AU" },
        new Country { Name = "Austria", Iso2Code = "AT" },
        new Country { Name = "Azerbaijan", Iso2Code = "AZ" },
        new Country { Name = "Bahamas", Iso2Code = "BS" },
        new Country { Name = "Bahrain", Iso2Code = "BH" },
        new Country { Name = "Bangladesh", Iso2Code = "BD" },
        new Country { Name = "Barbados", Iso2Code = "BB" },
        new Country { Name = "Belarus", Iso2Code = "BY" },
        new Country { Name = "Belgium", Iso2Code = "BE" },
        new Country { Name = "Belize", Iso2Code = "BZ" },
        new Country { Name = "Benin", Iso2Code = "BJ" },
        new Country { Name = "Bermuda", Iso2Code = "BM" },
        new Country { Name = "Bhutan", Iso2Code = "BT" },
        new Country { Name = "Bolivia", Iso2Code = "BO" },
        new Country { Name = "Bosnia and Herzegovina", Iso2Code = "BA" },
        new Country { Name = "Botswana", Iso2Code = "BW" },
        new Country { Name = "Bouvet Island", Iso2Code = "BV" },
        new Country { Name = "Brazil", Iso2Code = "BR" },
        new Country { Name = "British Virgin Islands", Iso2Code = "VG" },
        new Country { Name = "British Indian Ocean Territory", Iso2Code = "IO" },
        new Country { Name = "Brunei Darussalam", Iso2Code = "BN" },
        new Country { Name = "Bulgaria", Iso2Code = "BG" },
        new Country { Name = "Burkina Faso", Iso2Code = "BF" },
        new Country { Name = "Burundi", Iso2Code = "BI" },
        new Country { Name = "Cambodia", Iso2Code = "KH" },
        new Country { Name = "Cameroon", Iso2Code = "CM" },
        new Country { Name = "Canada", Iso2Code = "CA" },
        new Country { Name = "Cape Verde", Iso2Code = "CV" },
        new Country { Name = "Cayman Islands", Iso2Code = "KY" },
        new Country { Name = "Central African Republic", Iso2Code = "CF" },
        new Country { Name = "Chad", Iso2Code = "TD" },
        new Country { Name = "Chile", Iso2Code = "CL" },
        new Country { Name = "China", Iso2Code = "CN" },
        new Country { Name = "Hong Kong, Special Administrative Region of China", Iso2Code = "HK" },
        new Country { Name = "Macao, Special Administrative Region of China", Iso2Code = "MO" },
        new Country { Name = "Christmas Island", Iso2Code = "CX" },
        new Country { Name = "Cocos (Keeling) Islands", Iso2Code = "CC" },
        new Country { Name = "Colombia", Iso2Code = "CO" },
        new Country { Name = "Comoros", Iso2Code = "KM" },
        new Country { Name = "Congo (Brazzaville)", Iso2Code = "CG" },
        new Country { Name = "Congo, Democratic Republic of the", Iso2Code = "CD" },
        new Country { Name = "Cook Islands", Iso2Code = "CK" },
        new Country { Name = "Costa Rica", Iso2Code = "CR" },
        new Country { Name = "Côte d'Ivoire", Iso2Code = "CI" },
        new Country { Name = "Croatia", Iso2Code = "HR" },
        new Country { Name = "Cuba", Iso2Code = "CU" },
        new Country { Name = "Cyprus", Iso2Code = "CY" },
        new Country { Name = "Czech Republic", Iso2Code = "CZ" },
        new Country { Name = "Denmark", Iso2Code = "DK" },
        new Country { Name = "Djibouti", Iso2Code = "DJ" },
        new Country { Name = "Dominica", Iso2Code = "DM" },
        new Country { Name = "Dominican Republic", Iso2Code = "DO" },
        new Country { Name = "Ecuador", Iso2Code = "EC" },
        new Country { Name = "Egypt", Iso2Code = "EG" },
        new Country { Name = "El Salvador", Iso2Code = "SV" },
        new Country { Name = "Equatorial Guinea", Iso2Code = "GQ" },
        new Country { Name = "Eritrea", Iso2Code = "ER" },
        new Country { Name = "Estonia", Iso2Code = "EE" },
        new Country { Name = "Ethiopia", Iso2Code = "ET" },
        new Country { Name = "Falkland Islands (Malvinas)", Iso2Code = "FK" },
        new Country { Name = "Faroe Islands", Iso2Code = "FO" },
        new Country { Name = "Fiji", Iso2Code = "FJ" },
        new Country { Name = "Finland", Iso2Code = "FI" },
        new Country { Name = "France", Iso2Code = "FR" },
        new Country { Name = "French Guiana", Iso2Code = "GF" },
        new Country { Name = "French Polynesia", Iso2Code = "PF" },
        new Country { Name = "French Southern Territories", Iso2Code = "TF" },
        new Country { Name = "Gabon", Iso2Code = "GA" },
        new Country { Name = "Gambia", Iso2Code = "GM" },
        new Country { Name = "Georgia", Iso2Code = "GE" },
        new Country { Name = "Germany", Iso2Code = "DE" },
        new Country { Name = "Ghana", Iso2Code = "GH" },
        new Country { Name = "Gibraltar", Iso2Code = "GI" },
        new Country { Name = "Greece", Iso2Code = "GR" },
        new Country { Name = "Greenland", Iso2Code = "GL" },
        new Country { Name = "Grenada", Iso2Code = "GD" },
        new Country { Name = "Guadeloupe", Iso2Code = "GP" },
        new Country { Name = "Guam", Iso2Code = "GU" },
        new Country { Name = "Guatemala", Iso2Code = "GT" },
        new Country { Name = "Guernsey", Iso2Code = "GG" },
        new Country { Name = "Guinea", Iso2Code = "GN" },
        new Country { Name = "Guinea-Bissau", Iso2Code = "GW" },
        new Country { Name = "Guyana", Iso2Code = "GY" },
        new Country { Name = "Haiti", Iso2Code = "HT" },
        new Country { Name = "Heard Island and Mcdonald Islands", Iso2Code = "HM" },
        new Country { Name = "Holy See (Vatican City State)", Iso2Code = "VA" },
        new Country { Name = "Honduras", Iso2Code = "HN" },
        new Country { Name = "Hungary", Iso2Code = "HU" },
        new Country { Name = "Iceland", Iso2Code = "IS" },
        new Country { Name = "India", Iso2Code = "IN" },
        new Country { Name = "Indonesia", Iso2Code = "ID" },
        new Country { Name = "Iran, Islamic Republic of", Iso2Code = "IR" },
        new Country { Name = "Iraq", Iso2Code = "IQ" },
        new Country { Name = "Ireland", Iso2Code = "IE" },
        new Country { Name = "Isle of Man", Iso2Code = "IM" },
        new Country { Name = "Israel", Iso2Code = "IL" },
        new Country { Name = "Italy", Iso2Code = "IT" },
        new Country { Name = "Jamaica", Iso2Code = "JM" },
        new Country { Name = "Japan", Iso2Code = "JP" },
        new Country { Name = "Jersey", Iso2Code = "JE" },
        new Country { Name = "Jordan", Iso2Code = "JO" },
        new Country { Name = "Kazakhstan", Iso2Code = "KZ" },
        new Country { Name = "Kenya", Iso2Code = "KE" },
        new Country { Name = "Kiribati", Iso2Code = "KI" },
        new Country { Name = "Korea, Democratic People's Republic of", Iso2Code = "KP" },
        new Country { Name = "Korea, Republic of", Iso2Code = "KR" },
        new Country { Name = "Kuwait", Iso2Code = "KW" },
        new Country { Name = "Kyrgyzstan", Iso2Code = "KG" },
        new Country { Name = "Lao PDR", Iso2Code = "LA" },
        new Country { Name = "Latvia", Iso2Code = "LV" },
        new Country { Name = "Lebanon", Iso2Code = "LB" },
        new Country { Name = "Lesotho", Iso2Code = "LS" },
        new Country { Name = "Liberia", Iso2Code = "LR" },
        new Country { Name = "Libya", Iso2Code = "LY" },
        new Country { Name = "Liechtenstein", Iso2Code = "LI" },
        new Country { Name = "Lithuania", Iso2Code = "LT" },
        new Country { Name = "Luxembourg", Iso2Code = "LU" },
        new Country { Name = "Macedonia, Republic of", Iso2Code = "MK" },
        new Country { Name = "Madagascar", Iso2Code = "MG" },
        new Country { Name = "Malawi", Iso2Code = "MW" },
        new Country { Name = "Malaysia", Iso2Code = "MY" },
        new Country { Name = "Maldives", Iso2Code = "MV" },
        new Country { Name = "Mali", Iso2Code = "ML" },
        new Country { Name = "Malta", Iso2Code = "MT" },
        new Country { Name = "Marshall Islands", Iso2Code = "MH" },
        new Country { Name = "Martinique", Iso2Code = "MQ" },
        new Country { Name = "Mauritania", Iso2Code = "MR" },
        new Country { Name = "Mauritius", Iso2Code = "MU" },
        new Country { Name = "Mayotte", Iso2Code = "YT" },
        new Country { Name = "Mexico", Iso2Code = "MX" },
        new Country { Name = "Micronesia, Federated States of", Iso2Code = "FM" },
        new Country { Name = "Moldova", Iso2Code = "MD" },
        new Country { Name = "Monaco", Iso2Code = "MC" },
        new Country { Name = "Mongolia", Iso2Code = "MN" },
        new Country { Name = "Montenegro", Iso2Code = "ME" },
        new Country { Name = "Montserrat", Iso2Code = "MS" },
        new Country { Name = "Morocco", Iso2Code = "MA" },
        new Country { Name = "Mozambique", Iso2Code = "MZ" },
        new Country { Name = "Myanmar", Iso2Code = "MM" },
        new Country { Name = "Namibia", Iso2Code = "NA" },
        new Country { Name = "Nauru", Iso2Code = "NR" },
        new Country { Name = "Nepal", Iso2Code = "NP" },
        new Country { Name = "Netherlands", Iso2Code = "NL" },
        new Country { Name = "Netherlands Antilles", Iso2Code = "AN" },
        new Country { Name = "New Caledonia", Iso2Code = "NC" },
        new Country { Name = "New Zealand", Iso2Code = "NZ" },
        new Country { Name = "Nicaragua", Iso2Code = "NI" },
        new Country { Name = "Niger", Iso2Code = "NE" },
        new Country { Name = "Nigeria", Iso2Code = "NG" },
        new Country { Name = "Niue", Iso2Code = "NU" },
        new Country { Name = "Norfolk Island", Iso2Code = "NF" },
        new Country { Name = "Northern Mariana Islands", Iso2Code = "MP" },
        new Country { Name = "Norway", Iso2Code = "NO" },
        new Country { Name = "Oman", Iso2Code = "OM" },
        new Country { Name = "Pakistan", Iso2Code = "PK" },
        new Country { Name = "Palau", Iso2Code = "PW" },
        new Country { Name = "Palestinian Territory, Occupied", Iso2Code = "PS" },
        new Country { Name = "Panama", Iso2Code = "PA" },
        new Country { Name = "Papua New Guinea", Iso2Code = "PG" },
        new Country { Name = "Paraguay", Iso2Code = "PY" },
        new Country { Name = "Peru", Iso2Code = "PE" },
        new Country { Name = "Philippines", Iso2Code = "PH" },
        new Country { Name = "Pitcairn", Iso2Code = "PN" },
        new Country { Name = "Poland", Iso2Code = "PL" },
        new Country { Name = "Portugal", Iso2Code = "PT" },
        new Country { Name = "Puerto Rico", Iso2Code = "PR" },
        new Country { Name = "Qatar", Iso2Code = "QA" },
        new Country { Name = "Réunion", Iso2Code = "RE" },
        new Country { Name = "Romania", Iso2Code = "RO" },
        new Country { Name = "Russian Federation", Iso2Code = "RU" },
        new Country { Name = "Rwanda", Iso2Code = "RW" },
        new Country { Name = "Saint-Barthélemy", Iso2Code = "BL" },
        new Country { Name = "Saint Helena", Iso2Code = "SH" },
        new Country { Name = "Saint Kitts and Nevis", Iso2Code = "KN" },
        new Country { Name = "Saint Lucia", Iso2Code = "LC" },
        new Country { Name = "Saint-Martin (French part)", Iso2Code = "MF" },
        new Country { Name = "Saint Pierre and Miquelon", Iso2Code = "PM" },
        new Country { Name = "Saint Vincent and Grenadines", Iso2Code = "VC" },
        new Country { Name = "Samoa", Iso2Code = "WS" },
        new Country { Name = "San Marino", Iso2Code = "SM" },
        new Country { Name = "Sao Tome and Principe", Iso2Code = "ST" },
        new Country { Name = "Saudi Arabia", Iso2Code = "SA" },
        new Country { Name = "Senegal", Iso2Code = "SN" },
        new Country { Name = "Serbia", Iso2Code = "RS" },
        new Country { Name = "Seychelles", Iso2Code = "SC" },
        new Country { Name = "Sierra Leone", Iso2Code = "SL" },
        new Country { Name = "Singapore", Iso2Code = "SG" },
        new Country { Name = "Slovakia", Iso2Code = "SK" },
        new Country { Name = "Slovenia", Iso2Code = "SI" },
        new Country { Name = "Solomon Islands", Iso2Code = "SB" },
        new Country { Name = "Somalia", Iso2Code = "SO" },
        new Country { Name = "South Africa", Iso2Code = "ZA" },
        new Country { Name = "South Georgia and the South Sandwich Islands", Iso2Code = "GS" },
        new Country { Name = "South Sudan", Iso2Code = "SS" },
        new Country { Name = "Spain", Iso2Code = "ES" },
        new Country { Name = "Sri Lanka", Iso2Code = "LK" },
        new Country { Name = "Sudan", Iso2Code = "SD" },
        new Country { Name = "Suriname *", Iso2Code = "SR" },
        new Country { Name = "Svalbard and Jan Mayen Islands", Iso2Code = "SJ" },
        new Country { Name = "Swaziland", Iso2Code = "SZ" },
        new Country { Name = "Sweden", Iso2Code = "SE" },
        new Country { Name = "Switzerland", Iso2Code = "CH" },
        new Country { Name = "Syrian Arab Republic (Syria)", Iso2Code = "SY" },
        new Country { Name = "Taiwan, Republic of China", Iso2Code = "TW" },
        new Country { Name = "Tajikistan", Iso2Code = "TJ" },
        new Country { Name = "Tanzania *, United Republic of", Iso2Code = "TZ" },
        new Country { Name = "Thailand", Iso2Code = "TH" },
        new Country { Name = "Timor-Leste", Iso2Code = "TL" },
        new Country { Name = "Togo", Iso2Code = "TG" },
        new Country { Name = "Tokelau", Iso2Code = "TK" },
        new Country { Name = "Tonga", Iso2Code = "TO" },
        new Country { Name = "Trinidad and Tobago", Iso2Code = "TT" },
        new Country { Name = "Tunisia", Iso2Code = "TN" },
        new Country { Name = "Turkey", Iso2Code = "TR" },
        new Country { Name = "Turkmenistan", Iso2Code = "TM" },
        new Country { Name = "Turks and Caicos Islands", Iso2Code = "TC" },
        new Country { Name = "Tuvalu", Iso2Code = "TV" },
        new Country { Name = "Uganda", Iso2Code = "UG" },
        new Country { Name = "Ukraine", Iso2Code = "UA" },
        new Country { Name = "United Arab Emirates", Iso2Code = "AE" },
        new Country { Name = "United Kingdom", Iso2Code = "GB" },
        new Country { Name = "United States of America", Iso2Code = "US" },
        new Country { Name = "United States Minor Outlying Islands", Iso2Code = "UM" },
        new Country { Name = "Uruguay", Iso2Code = "UY" },
        new Country { Name = "Uzbekistan", Iso2Code = "UZ" },
        new Country { Name = "Vanuatu", Iso2Code = "VU" },
        new Country { Name = "Venezuela (Bolivarian Republic of)", Iso2Code = "VE" },
        new Country { Name = "Viet Nam", Iso2Code = "VN" },
        new Country { Name = "Virgin Islands, US", Iso2Code = "VI" },
        new Country { Name = "Wallis and Futuna Islands", Iso2Code = "WF" },
        new Country { Name = "Western Sahara", Iso2Code = "EH" },
        new Country { Name = "Yemen", Iso2Code = "YE" },
        new Country { Name = "Zambia", Iso2Code = "ZM" },
        new Country { Name = "Zimbabwe", Iso2Code = "ZW"}
      };
    }
  }
}