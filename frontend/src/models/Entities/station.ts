import { FuelTank } from "./fuel-tank"

export interface Station 
{
    id: number,
    name: string,
    userId: number
    fuelTanks: Array<FuelTank>
}