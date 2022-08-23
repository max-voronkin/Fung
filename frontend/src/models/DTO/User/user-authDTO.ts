import { User } from "src/models/Entities/user";

export interface AuthUserDTO 
{
    user: User,
    token: string
}