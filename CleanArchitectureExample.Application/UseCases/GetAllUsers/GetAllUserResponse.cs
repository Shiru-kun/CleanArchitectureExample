namespace CleanArchitectureExample.Application.UseCases.GetAllUsers
{
    public sealed class GetAllUserResponse
    {
        public Guid Id { get; set; }
        public string? Email { get; set; } = string.Empty;
    }
}