import { Settings } from "src/models/Entities/settings"
import { User } from "src/models/Entities/user"

export interface AuthUserDTO 
{
    accessToken: string
    refreshToken: string
    user: User
    settings: Settings
}