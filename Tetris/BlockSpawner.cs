﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tetris
{
    class BlockSpawner
    {
        /// <summary>
        /// A spawner which will create the next blocks to be played
        /// </summary>
        public BlockSpawner()
        {
            positionSpawner = new BlockPositionSpawner();
        }

        /// <summary>
        /// A position spawner to specify the positions of the new blocks
        /// </summary>
        BlockPositionSpawner positionSpawner;

        /// <summary>
        /// Returns the next block to play with
        /// </summary>
        /// <returns>The next block to play with</returns>
        public Block Next()
        {
            return new Block(positionSpawner);
        }
    }
}