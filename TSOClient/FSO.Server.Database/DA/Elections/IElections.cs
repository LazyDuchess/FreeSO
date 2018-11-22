﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSO.Server.Database.DA.Elections
{
    public interface IElections
    {
        DbElectionCycle GetCycle(uint cycle_id);
        DbElectionCandidate GetCandidate(uint avatar_id, uint cycle_id, DbCandidateState state);
        List<DbElectionCandidate> GetCandidates(uint cycle_id, DbCandidateState state);
        List<DbElectionCandidate> GetCandidates(uint cycle_id);
        List<DbElectionVote> GetCycleVotes(uint cycle_id, DbElectionVoteType type);
        List<DbElectionVote> GetCycleVotesForAvatar(uint avatar_id, uint cycle_id, DbElectionVoteType type);
        DbElectionVote GetMyVote(uint avatar_id, uint cycle_id, DbElectionVoteType type);
        DbMayorRating GetSpecificRating(uint from_user_id, uint to_avatar_id);
        DbMayorRating GetRating(uint rating_id);
        List<uint> GetRatings(uint to_avatar_id);
        float? GetAvgRating(uint to_avatar_id);
        bool CreateCandidate(DbElectionCandidate candidate);
        bool SetCandidateState(DbElectionCandidate candidate);
        bool DeleteCandidate(uint election_cycle_id, uint candidate_avatar_id);
        uint CreateCycle(DbElectionCycle cycle);
        bool CreateVote(DbElectionVote vote);
        void UpdateCycleState(uint cycle_id, DbElectionCycleState state);
        uint SetRating(DbMayorRating rating);
        bool DeleteRating(uint id);

        bool EmailRegistered(DbElectionCycleMail p);
        bool TryRegisterMail(DbElectionCycleMail p);

        DbElectionWin FindLastWin(uint avatar_id);
    }

    public class DbElectionWin
    {
        public uint nhood_id { get; set; }
        public string nhood_name { get; set; }
    }
}
