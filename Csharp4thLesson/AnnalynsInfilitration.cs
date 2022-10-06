using System;
static class QuestLogic
{
    public static bool CanFastAttack(bool knightIsAwake)
    {
        if(knightIsAwake){
            return false;
        }else
            return true;
        throw new NotImplementedException("Please implement the (static) QuestLogic.CanFastAttack() method");
    }
    public static bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake)
    {
        if(!knightIsAwake&&!archerIsAwake&&!prisonerIsAwake)
        {
            return false;
        }
        else 
        return true;
        throw new NotImplementedException("Please implement the (static) QuestLogic.CanSpy() method");
    }
    public static bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake)
    {
        if(!archerIsAwake && prisonerIsAwake)
        {
            return true;
        }
    else
        return false;
        throw new NotImplementedException("Please implement the (static) QuestLogic.CanSignalPrisoner() method");
    }
    public static bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool petDogIsPresent)
    {
       if(petDogIsPresent&&!archerIsAwake)
       {
           return true;
       }
    else if(!petDogIsPresent&&prisonerIsAwake&&!knightIsAwake&&!archerIsAwake)
    {
        return true;
    }
        else
            return false;
        throw new NotImplementedException("Please implement the (static) QuestLogic.CanFreePrisoner() method");
    }
}
