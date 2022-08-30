export interface LevelTransaction
{
    id: number,
    height: number,
    temperature: number,
    volume: number,
    density: number,
    transactionTime: Date,
    fuelTankId: number
}