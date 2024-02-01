using System;
namespace MultiLangProject.Utilities {
  public static class StringUtils {
    public static string ToTitleCase(string input) {
      return System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(input.ToLower());
    }
  }
}
