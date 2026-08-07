
namespace NES.Domain.Common;

public interface ISoftDelete
{
    bool IsDeleted { get; }

    void SoftDelete();
}