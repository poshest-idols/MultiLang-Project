using System;
namespace MultiLangProject {
  public static class TextUtilities {
    public static string Reverse(string input) {
      char[] array = input.ToCharArray();
      Array.Reverse(array);
      return new string(array);
    }
  }
}
