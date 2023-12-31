﻿using System;
using System.Collections.Generic;

namespace OOP1_3
{
	public class BasvuruManager
	{
		//method injection
		public void BasvuruYap(IKrediManager krediManager, ILoggerService loggerService)
		{
			//Başvuran bilgilerini değerlendirme
			krediManager.Hesapla();
			loggerService.Log();
		}

		public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
		{
			foreach (var kredi in krediler)
			{
				kredi.Hesapla();
			}
		}
	}
}

