﻿using System.Collections.Generic;
using UnityEngine;

public class TeamMemberGenerator : MonoBehaviour
{
    [SerializeField] private TeamMemberNameDatabase _database;

    private TeamMember GenerateNewTeamMember()
    {
        var memberName = _database.GetRandomNameFromDatabase();
        var programmingRank = Random.Range(0, 100 + 1);
        var artRank = Random.Range(0, 100 + 1);
        var soundDesignRank = Random.Range(0, 100 + 1);
        var studioDevelopmentRank = Random.Range(0, 100 + 1);
        var marketingRank = Random.Range(0, 100 + 1);

        var newMember = new TeamMember(memberName, programmingRank, artRank, soundDesignRank, studioDevelopmentRank, marketingRank);

        return newMember;
    }

    public List<TeamMember> GenerateTeamMembers(int batchSize)
    {
        var batch = new List<TeamMember>(batchSize);

        for (var i = 0; i < batchSize; i++)
        {
            batch.Add(GenerateNewTeamMember());
        }

        return batch;
    }
}