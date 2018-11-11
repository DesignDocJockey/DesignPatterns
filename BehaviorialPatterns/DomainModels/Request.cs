using System;

namespace BehaviorialPatterns.DomainModels
{
    public class Request
    {
        public Guid Id { get; set; }
        public string LoginId { get; set; }
        public string Password { get; set; }
        public bool IsAuthenticated { get; set; }
        public bool IsAuthorized { get; set; }
        public bool AllowAccess { get; set; }
    }
}
