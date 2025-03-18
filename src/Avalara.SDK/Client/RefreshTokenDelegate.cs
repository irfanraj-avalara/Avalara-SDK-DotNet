using System.Threading.Tasks;

namespace Avalara.SDK.Client
{
    /// <summary>
    /// Delegate for getting a new refresh token.
    /// </summary>
    public delegate Task<string> RefreshTokenDelegate();
}