﻿using ManagedPatcher.Patcher.Properties;

namespace ManagedPatcher.Patcher.Setup
{
	public class ProgramSetting<T>
	{
		public readonly string key;

		public ProgramSetting(string key) {
			this.key = key;
		}

		public void Set(T value) {
			Settings.Default[key] = value;
			Settings.Default.Save();
		}

		public T Get() {
			return (T)Settings.Default[key];
		}
	}
}