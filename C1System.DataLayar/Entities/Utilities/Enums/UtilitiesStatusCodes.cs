﻿namespace C1System.DataLayar.Entities.Utilities.Enums;

public enum UtilitiesStatusCodes
{
    Success = 200,
    BadRequest = 400,
    Forbidden = 403,
    NotFound = 404,
    // Unhandled = 900,
    // New = 499,
    // WrongMobile = 601,
    // WrongVerificationCode = 602,
}

public static class UtilitiesStatusCodesExtension {
    public static bool isSuccessfull(this UtilitiesStatusCodes statusCode) => statusCode == UtilitiesStatusCodes.Success;
    public static bool isBadRequest(this UtilitiesStatusCodes statusCode) => statusCode == UtilitiesStatusCodes.BadRequest;
    public static bool isForbidden(this UtilitiesStatusCodes statusCode) => statusCode == UtilitiesStatusCodes.Forbidden;
    public static bool isNotFound(this UtilitiesStatusCodes statusCode) => statusCode == UtilitiesStatusCodes.NotFound;
    public static int value(this UtilitiesStatusCodes statusCode) => (int) statusCode;
}