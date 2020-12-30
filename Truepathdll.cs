var result = injector.CreateRemoteThread("pathToDll", "processName");

                switch (result)
                {
                    case DllInjectionResult.DllNotFound:
                        Print("Dll not found.", true);
                        break;
                    case DllInjectionResult.GameProcessNotFound:
                        Print("Process not found.", true);
                        break;
                    case DllInjectionResult.InjectionFailed:
                        Print("Loading failed.", true);
                        break;
                    case DllInjectionResult.Success:
                        Print("Successfully loaded!");
                        LoadBtn.Enabled = false;
                        LoadBtn.Text = @"Loaded!";
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
