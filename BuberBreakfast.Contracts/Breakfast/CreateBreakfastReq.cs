namespace BuberBreakfast.Contracts.Breakfast;

public record CreateBreakfastReq(
    string Name,
    string Description,
    DateTime StartDateTime,
    DateTime EndDateTime,
    List<string> Savory,
    List<string> Sweet
);