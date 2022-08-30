export interface FuelTank
{
    id: number,
    name: string,
    capacity: number,
    currentAmount: number,
    stationId: number,
    updatedAt: Date
}