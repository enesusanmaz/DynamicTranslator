﻿using System.Collections.Generic;
using DynamicTranslator.Configuration.Startup;
using DynamicTranslator.LanguageManagement;

namespace DynamicTranslator.Tureng
{
	public class TurengTranslatorConfiguration : AbstractTranslatorConfiguration
	{
		private readonly ApplicationConfiguration _applicationConfiguration;

		public override bool CanSupport()
		{
			return base.CanSupport() && _applicationConfiguration.IsToLanguageTurkish;
		}

		public override IList<Language> SupportedLanguages { get; set; }

		public override string Url { get; set; }

		public override TranslatorType TranslatorType => TranslatorType.Tureng;

		public TurengTranslatorConfiguration(ActiveTranslatorConfiguration activeTranslatorConfiguration, ApplicationConfiguration applicationConfiguration) : base(activeTranslatorConfiguration, applicationConfiguration)
		{
			_applicationConfiguration = applicationConfiguration;
		}
	}
}