using System;
namespace MultiLangProject {
  public static class AdvancedUtilities {
    public static int Factorial(int n) => n <= 1 ? 1 : n * Factorial(n - 1);
  }
}
