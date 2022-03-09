using System.Collections.Generic;

namespace session;
public class Session
{
    
    public DateTime ScheduledTime {get; set;}
    public TimeSpan Duration {get; set;}

}

// ":" Used for a "kind-of" relationship
// SpeakerSession is a type of session. (Inheritance)
class SpeakerSession : Session
{
    public List<Speaker> ?GuestSpeakers {get; set;}
}

